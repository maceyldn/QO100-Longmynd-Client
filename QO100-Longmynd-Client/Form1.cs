using LibVLCSharp.Shared;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using TSParser.Mpeg;
using TSParser.Mpeg.Descriptors;
using TSParser.Mpeg.Psi;
using TSParser.Util;
using WebSocketSharp;

namespace QO100LongmyndClient
{
    public partial class Form1 : Form
    {
        private static readonly ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        private const int port = 5011;
        public UdpClient udpmetadataclient;
        public UdpClient udptsclient;
        public String state;
        public bool dvbs2 = false;
        Dictionary<int, String> DVBSLookup = new Dictionary<int, string>();
        Dictionary<int, String> DVBS2Lookup = new Dictionary<int, string>();
        bool playing = false;
        Thread UdpThread;
        Thread UdpTSThread;
        TransportStream ts;

        private static readonly Object list_lock = new Object();
        private WebSocket ws;       //websocket client

        static int width = 922;     //web monitor uses 922 points, 6 padded?
        static int height = 255;    //makes things easier

        static Bitmap bmp = new Bitmap(width, height + 15);
        static Bitmap bmp2 = new Bitmap(width, 15);     //bandplan
        Pen greenpen = new Pen(Color.FromArgb(200, 20, 200, 20));
        Pen greypen = new Pen(Color.Gray, width: 1) { DashPattern = new[] { 10f, 10f } };
        SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(128, Color.Gray));
        SolidBrush bandplanBrush = new SolidBrush(Color.FromArgb(100, 150, 150, 255));

        Graphics tmp = Graphics.FromImage(bmp);
        Graphics tmp2 = Graphics.FromImage(bmp2);

        UInt16[] fft_data;  //array of spectrum values
        List<List<double>> signals = new List<List<double>>();  //list of signals found: 
        bool connected = false;

        //udp port stuff
        UdpClient MT_Client = new UdpClient();
        System.Net.IPEndPoint sending_end_point;


        int[,] rx_blocks = new int[6, 3];
        XElement bandplan;
        System.Timers.Timer timeout = new System.Timers.Timer();        //detect websocket timeout
        System.Timers.Timer udptimeout = new System.Timers.Timer();
        System.Timers.Timer udptstimeout = new System.Timers.Timer();
        System.Timers.Timer bitratetimer = new System.Timers.Timer();
        
        double start_freq = 10490.5f;

        DateTime lastseen;
        bool demodlocked = false;
        bool streamactive = false;
        LibVLC _libVLC;
        MediaPlayer _mediaPlayer;
        
        bool recording = false;
        BinaryWriter saveTSWriter;

        public Form1()
        {
            InitializeComponent();

            ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
            var fileInfo = new FileInfo(@"log4net.config");

            XmlConfigurator.Configure(repository, fileInfo);
        }

        private void MediaPlayerOnLog(object sender, LogEventArgs e)
        {
            logger.Info(e.Message);
            //tbLog.Invoke((MethodInvoker)delegate { tbLog.AppendText(e.Message+Environment.NewLine); });
        }

        int videopid;
        int audiopid;

        private bool UdpMetaDataThreadRunning = true;
        private bool UdpTSThreadRunning = true;
        private string saveTSFilename;

        private void NewPMTEvent(object sender, TSParser.Mpeg.Psi.PMTEventArgs e)
        {
            //Logger.Info("PMT INFO");
            foreach (PMTsection p in e._sections)
            {
                //Logger.Info(p);
                foreach (PMTsection.Component c in p.GetComponentList())
                {
                    //Logger.Info(" - " + c);
                    foreach (Descriptor d in c.GetComponentDescriptorList())
                    {
                        //Logger.Info(" - - " + d);
                    }

                    switch (c.GetStreamtype())
                    {
                        case 36:
                            lblcodecvalue.Invoke((MethodInvoker)delegate { lblcodecvalue.Text = c.GetStreamTypeString(); });
                            videopid = c.GetElementaryPID();
                            break;

                        case 27:
                            lblcodecvalue.Invoke((MethodInvoker)delegate { lblcodecvalue.Text = c.GetStreamTypeString(); });
                            videopid = c.GetElementaryPID();
                            break;
                        case 15:
                            lblaudiocodec.Invoke((MethodInvoker)delegate { lblaudiocodec.Text = c.GetStreamTypeString(); });
                            audiopid = c.GetElementaryPID();
                            break;
                        case 3:
                            lblaudiocodec.Invoke((MethodInvoker)delegate { lblaudiocodec.Text = c.GetStreamTypeString(); });
                            audiopid = c.GetElementaryPID();
                            break;
                        default:
                          //  Logger.Info(c);
                            break;
                    }
                    
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Core.Initialize();
            _libVLC = new LibVLC("--verbose=2");
            _mediaPlayer = new MediaPlayer(_libVLC);
            _libVLC.Log += MediaPlayerOnLog;
            videoView1.MediaPlayer = _mediaPlayer;

            ///Build Mod Code Dict-

            DVBSLookup.Add(0, "QPSK 1/2");
            DVBSLookup.Add(1, "QPSK 2/3");
            DVBSLookup.Add(2, "QPSK 3/4");
            DVBSLookup.Add(3, "QPSK 5/6");
            DVBSLookup.Add(4, "QPSK 6/7");
            DVBSLookup.Add(5, "QPSK 7/8");

        
            DVBS2Lookup.Add(0, "DummyPL");
            DVBS2Lookup.Add(1, "QPSK 1/4");
            DVBS2Lookup.Add(2, "QPSK 1/3");
            DVBS2Lookup.Add(3, "QPSK 2.5");
            DVBS2Lookup.Add(4, "QPSK 1/2");
            DVBS2Lookup.Add(5, "QPSK 3/5");
            DVBS2Lookup.Add(6, "QPSK 2/3");
            DVBS2Lookup.Add(7, "QPSK 3/4");
            DVBS2Lookup.Add(8, "QPSK 4/5");
            DVBS2Lookup.Add(9, "QPSK 5/6");
            DVBS2Lookup.Add(10, "QPSK 8/9");
            DVBS2Lookup.Add(11, "QPSK 9/10");
            DVBS2Lookup.Add(12, "8PSK 3/5");
            DVBS2Lookup.Add(13, "8PSK 2/3");
            DVBS2Lookup.Add(14, "8PSK 3/4");
            DVBS2Lookup.Add(15, "8PSK 5/6");
            DVBS2Lookup.Add(16, "8PSK 8/9");
            DVBS2Lookup.Add(17, "8PSK 9/10");
            DVBS2Lookup.Add(18, "16APSK 2/3");
            DVBS2Lookup.Add(19, "16APSK 3/4");
            DVBS2Lookup.Add(20, "16APSK 4/5");
            DVBS2Lookup.Add(21, "16APSK 5/6");
            DVBS2Lookup.Add(22, "16APSK 8/9");
            DVBS2Lookup.Add(23, "16APSK 9/10");
            DVBS2Lookup.Add(24, "32APSK 3/4");
            DVBS2Lookup.Add(25, "32APSK 4/5");
            DVBS2Lookup.Add(26, "32APSK 5/6");
            DVBS2Lookup.Add(27, "32APSK 8/9");
            DVBS2Lookup.Add(28, "32APSK 9/10");

            StartupWSS();

            bitratetimer.Interval = 500;
            bitratetimer.Elapsed += OnBitrateTimer;
            bitratetimer.AutoReset = true;
            bitratetimer.Enabled = true;

            udptimeout.Interval = 500;
            udptimeout.Elapsed += Udptimeout_Elapsed;
            udptimeout.Enabled = false;
            udptimeout.AutoReset = false;

            udptstimeout.Interval = 10;
            udptstimeout.Elapsed += Udptstimeout_Elapsed;
            udptstimeout.Enabled = false;
            udptstimeout.AutoReset = false;

            UdpThread = new Thread(ReceiveMetaData);
            UdpThread.IsBackground = true;
            UdpThread.Start();

            ResetTS();
            
            UdpTSThread = new Thread(ReceiveTSData);
            UdpTSThread.Name = "TSProcessing";
            UdpTSThread.IsBackground = true;
            UdpTSThread.Start();
}

            private void Udptstimeout_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (demodlocked)
            {
                if (ledBulb2.Color == Color.Green)
                {
                    ledBulb2.Color = Color.Red;
                    ResetAll();
                }
            }
        }

        private void Udptimeout_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!demodlocked)
            {
                ResetAll();
            }
        }

        private void OnBitrateTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (ts.GetPids() != null)
            {
               if (demodlocked)
                {
                    try
                    {
                        if (ts.GetPids().GetValue(8191) != null) lblPercentNullvalue.Invoke((MethodInvoker)delegate { lblPercentNullvalue.Text = Utils.GetBWFriendly(ts.GetPids()[8191].GetBitRate()); });
                        if (ts.GetPids().GetValue(videopid) != null) { String vb = Utils.GetBWFriendly(ts.GetPids()[videopid].GetBitRate()); lblvbitratevalue.Invoke((MethodInvoker)delegate { lblvbitratevalue.Text = vb; }); }
                        if (ts.GetPids().GetValue(audiopid) != null) { String ab = Utils.GetBWFriendly(ts.GetPids()[audiopid].GetBitRate()); lblabitratevalue.Invoke((MethodInvoker)delegate { lblabitratevalue.Text = ab; }); }

                        ts.CalculateBitRate();
                        lblTotalBitratevalue.Invoke((MethodInvoker)delegate { lblTotalBitratevalue.Text = Utils.GetBWFriendly(ts.GetBitRate()); });
                    }
                    catch (Exception exp)
                    {
                        logger.Info(exp.Message);
                    }
                }
           }
        }

       
        private void ResetGUI()
        {
          
                ledBulb1.Invoke((MethodInvoker)delegate { ledBulb1.Color = Color.Red; });
                ledBulb2.Invoke((MethodInvoker)delegate { ledBulb2.Color = Color.Red; });
                lblServiceNamevalue.Invoke((MethodInvoker)delegate { lblServiceNamevalue.Text = ""; });
                lblServiceProviderValue.Invoke((MethodInvoker)delegate { lblServiceProviderValue.Text = ""; });
                lblBERvalue.Invoke((MethodInvoker)delegate { lblBERvalue.Text = ""; });
                lblDVBtypevalue.Invoke((MethodInvoker)delegate { lblDVBtypevalue.Text = ""; });
                lblMERvalue.Invoke((MethodInvoker)delegate { lblMERvalue.Text = ""; });
                lblMODTypevalue.Invoke((MethodInvoker)delegate { lblMODTypevalue.Text = ""; });
                lblPercentNullvalue.Invoke((MethodInvoker)delegate { lblPercentNullvalue.Text = ""; });
                lblStatusvalue.Invoke((MethodInvoker)delegate { lblStatusvalue.Text = ""; });
                lblcodecvalue.Invoke((MethodInvoker)delegate { lblcodecvalue.Text = ""; });
                lblaudiocodec.Invoke((MethodInvoker)delegate { lblaudiocodec.Text = ""; });
                lblTotalBitratevalue.Invoke((MethodInvoker)delegate { lblTotalBitratevalue.Text = ""; });
                lblvbitratevalue.Invoke((MethodInvoker)delegate { lblvbitratevalue.Text = ""; });
                lblabitratevalue.Invoke((MethodInvoker)delegate { lblabitratevalue.Text = ""; });
           
        }

        static void SendUdp(string dstIp, int dstPort, byte[] data)
        {
            using (UdpClient c = new UdpClient())
                c.Send(data, data.Length, dstIp, dstPort);
        }

        public void ReceiveTSData()
        {
                                   
            udptsclient = new UdpClient();
            udptsclient.ExclusiveAddressUse = false;

            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, 5010);
            udptsclient.Client.Bind(localEp);
            udptsclient.JoinMulticastGroup(IPAddress.Parse("239.100.100.50"));
            
            while (UdpTSThreadRunning)
            {
                if (demodlocked)
                {
                    
                    byte[] data = udptsclient.Receive(ref localEp);
                    if (ts != null)
                    {
                        SendUdp("127.0.0.1", 5500, data);
                        try
                        {
                            ts.EnqueuePacket(data, data.Length);
                        }catch (Exception e)
                        {
                            logger.Info(e.Message);
                        }
                    }

                    if (recording)
                    {
                        if (saveTSWriter == null)
                        {
                            saveTSWriter = new BinaryWriter(File.Open(saveTSFilename, FileMode.Create));
                        }

                        saveTSWriter.Write(data, 0, data.Length);
                    }

                    if (ledBulb2.Color == Color.Red)
                    {
                        ledBulb2.Invoke((MethodInvoker)delegate { ledBulb2.Color = Color.Green; });
                    }
                    //udptstimeout.Stop();
                    //
                    //udptstimeout.Start();
                }
            }
        }

            public void ReceiveMetaData()
            {
            udpmetadataclient = new UdpClient();

            //IPEndPoint localEp = new IPEndPoint(IPAddress.Parse("192.168.104.183"), port);
            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, port);
            udpmetadataclient.Client.Bind(localEp);
            udpmetadataclient.JoinMulticastGroup(IPAddress.Parse("239.100.100.50"));
            
            while (UdpMetaDataThreadRunning)
            {
                try
                {
                    byte[] data = udpmetadataclient.Receive(ref localEp);
                    string text = Encoding.UTF8.GetString(data).TrimStart('$');
                    string[] message = text.Split(',');
                    //Chop "@" from start.
                    Process(message);

                    udptimeout.Stop();
                    udptimeout.Start();
                    //Console.WriteLine(text);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                }
            }
        }



        private void Process(string[] message)
        {
           // locked = false;
            lastseen = DateTime.UtcNow;

            //       LongMyndStatus t;
            switch (message[0])
            {
                case "1":
                    //Console.Write(message[1]);
                    //Console.Write(message[1]);
                        switch (message[1].TrimEnd('\n'))
                        {
                        case "0":
                                state = "Initialising...";
                                lblStatusvalue.Invoke((MethodInvoker)delegate { lblStatusvalue.Text = state; });
                                demodlocked = false;
                            streamactive = false;
                          ResetGUI();
                            break;
                        case "1":
                                state = "Searching...";
                                lblStatusvalue.Invoke((MethodInvoker)delegate { lblStatusvalue.Text = state; });
                                demodlocked = false;
                            streamactive = false;
                            //ResetGUI();
                            break;
                        case "2":
                                state = "Found Headers...";
                                lblStatusvalue.Invoke((MethodInvoker)delegate { lblStatusvalue.Text = state; });
                                demodlocked = false;
                            streamactive = false;
                            break;
                        case "3":
                                state = "Locked DVB-S...";
                                dvbs2 = false;
                                ledBulb1.Color = Color.Green;
                                ShowVideo();
                                lblStatusvalue.Invoke((MethodInvoker)delegate { lblStatusvalue.Text = state; });
                                demodlocked = true;
                            if (!streamactive)
                            {
                                ResetAll();
                                streamactive = true;
                              }

                            break;
                        case "4":                    
                                state = "Locked DVB-S2...";
                                ledBulb1.Color = Color.Green;
                                ShowVideo();
                                dvbs2 = true;
                                lblStatusvalue.Invoke((MethodInvoker)delegate { lblStatusvalue.Text = state; });
                                demodlocked = true;
                            if (!streamactive)
                            {
                                ResetAll();
                                streamactive = true;
                              }

                            break;
                        default:
                            state = "Unknown";
                            ledBulb1.Color = Color.Red;
                            break;
                    }

                    if (demodlocked)
                    {
                        if (dvbs2)
                        {
                            lblDVBtypevalue.Invoke((MethodInvoker)delegate { lblDVBtypevalue.Text = "DVB-S2"; });
                        }
                        else
                        {
                            lblDVBtypevalue.Invoke((MethodInvoker)delegate { lblDVBtypevalue.Text = "DVB-S"; });
                        }
                    }
                    break;
                case "11":

                     if (demodlocked) lblBERvalue.Invoke((MethodInvoker)delegate { lblBERvalue.Text = message[1]; });
                    break;
                case "12":
                     if (demodlocked) lblMERvalue.Invoke((MethodInvoker)delegate { lblMERvalue.Text = message[1]; });
                    break;
                case "13":
                    //if (!guitimeout.Enabled) lblServiceProviderValue.Invoke((MethodInvoker)delegate { lblServiceProviderValue.Text = message[1]; });
                    break;
                case "14":
                    //if (!guitimeout.Enabled) lblServiceNamevalue.Invoke((MethodInvoker)delegate { lblServiceNamevalue.Text = message[1]; });
                    break;
                case "15":
                  
                    break;
                case "18":

                    if (demodlocked)
                    {
                        //value
                        if (!dvbs2)
                        {
                            String value;
                            DVBSLookup.TryGetValue(int.Parse(message[1]), out value);
                            lblMODTypevalue.Invoke((MethodInvoker)delegate { lblMODTypevalue.Text = value; });
                        }
                        else
                        {
                            String value;
                            DVBS2Lookup.TryGetValue(int.Parse(message[1]), out value);
                            lblMODTypevalue.Invoke((MethodInvoker)delegate { lblMODTypevalue.Text = value; });
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void ResetAll()
        {
            StopVideo();
            ResetGUI();
            ResetTS();
            //ShowVideo();
            udptimeout.Enabled = true;
        }

        private void ShowVideo()
        {
            
            if (!playing)
            {
                _mediaPlayer.Play(new Media(_libVLC, "udp://@:5500", FromType.FromLocation));
                playing = true;
            }
        }

        private void StartupWSS()
        {
            if (!connected)
            {
                
                ws = new WebSocket("wss://eshail.batc.org.uk/wb/fft_m0dtslivetune");
                ws.OnMessage += (ss, ee) => NewData(ee.RawData);
                ws.OnOpen += (ss, ee) => { 
                    connected = true; 
                    //toolStripStatusLabel1.Invoke((MethodInvoker)delegate { toolStripStatusLabel1.Text = "Disconnect"; });  
                };
                ws.OnClose += (ss, ee) => { 
                    connected = false; 
                    //toolStripStatusLabel1.Invoke((MethodInvoker)delegate { toolStripStatusLabel1.Text = "Connect"; }); 
                };

                try
                {
                    ws.Connect();
                } catch (Exception e)
                {
                    //Logger.info("Failed to connect, trying again
                    logger.Info(e.Message);
                    ws.Connect();
                }
                timeout.Enabled = true;
            }
            else
            {
                ws.Close();
                timeout.Enabled = false;
            }
        }

        private void NewData(byte[] data)
        {
            timeout.Stop();     //restart websocket activity timer
            timeout.Start();

            //Console.WriteLine(data[0]);
            fft_data = new UInt16[data.Length / 2];


            //unpack bytes to unsigned short int values
            int n = 0;
            byte[] buf = new byte[2];

            for (int i = 0; i < data.Length; i += 2)
            {
                buf[0] = data[i];
                buf[1] = data[i + 1];
                fft_data[n] = BitConverter.ToUInt16(buf, 0);
                n++;
            }

            //detect signals, stolen from web monitor javascript ;-)
            detect_signals(fft_data);

            //draw the spectrum
            drawspectrum(fft_data, signals);

        }






        private void drawspectrum_bandplan()
        {


            int span = 9;

            foreach (var channel in bandplan.Elements("channel"))
            {
                int w = 0;
                int offset = 0;
                float rolloff = 1.35f;
                float freq = Convert.ToSingle(channel.Element("x-freq").Value);
                int sr = Convert.ToInt32(channel.Element("sr").Value);

                int pos = Convert.ToInt16((922.0 / span) * (freq - start_freq));
                w = Convert.ToInt32(sr / (span * 1000.0) * 922 * rolloff);

                switch (channel.Element("sr").Value)
                {
                    case "2000":
                        offset = 8;
                        break;
                    case "1000":
                        offset = 0;
                        break;
                    case "333":
                        offset = 8;
                        break;
                    case "125":
                        offset = 0;
                        break;
                }

                tmp2.FillRectangles(bandplanBrush, new RectangleF[] { new System.Drawing.Rectangle(pos - (w / 2), offset, w, 3) });      //x,y,w,h
            }


        }


        private void drawspectrum(UInt16[] fft_data, List<List<double>> signals)
        {
            //int receivers = RxList.Items.Count;
            int receivers = 1;
            tmp.Clear(Color.Black);     //clear canvas
            tmp.DrawImage(bmp2, new Point(0, 255)); //bandplan

            //draw lines to segment y axis determining where to click for each receiver
            if (receivers >= 1)
            {
                int y = 0;
                int tyoffset = 0;
                for (int i = 0; i < receivers; i++)
                {
                    y = 255 - ((255 / receivers) * i + 2);
                    tyoffset = (255 / receivers) / 2 + 10;
                    if (i > 0)
                    {
                        tmp.DrawLine(greypen, 0, y, 922, y);
                    }
                    tmp.DrawString((receivers - (i)).ToString(), new Font("Tahoma", 10), Brushes.White, new PointF(Convert.ToSingle(0), (255 - tyoffset - Convert.ToSingle((255 / receivers) * i + 1))));
                    if (rx_blocks[i, 0] > 0)
                    {
                        //draw block showing signal selected
                        tmp.FillRectangles(shadowBrush, new RectangleF[] { new System.Drawing.Rectangle(rx_blocks[i, 0] - (rx_blocks[i, 1] / 2), 255 - y + 1, rx_blocks[i, 1], (255 / receivers) - 4) });

                    }
                }
            }


            for (int i = 1; i < fft_data.Length - 3; i++)     //ignore padding?
            {

                tmp.DrawLine(greenpen, i - 1, 255 - fft_data[i - 1] / 255, i, 255 - fft_data[i] / 255);
            }

            lock (list_lock)
            {
                //draw the text for each signal found
                foreach (List<double> sig in signals)
                {
                    tmp.DrawString(sig[1].ToString("#.000") + " " + (sig[2] * 1000).ToString("#Ks"), new Font("Tahoma", 10), Brushes.White, new PointF(Convert.ToSingle(sig[0] - 50), (255 - Convert.ToSingle(sig[3] + 30))));
                }
            }

            try
            {
                pbSpectrum.Image = bmp;       //pass bitmap to gui picture frame
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void spectrum_Click(object sender, EventArgs e)
        {
               MouseEventArgs me = (MouseEventArgs)e;
               Point pos = me.Location;

                lock (list_lock)
                {
                    foreach (List<double> sig in signals)
                    {
                        if (pos.X > sig[4] & pos.X < sig[5])
                        {
                            rx_blocks[0, 0] = Convert.ToInt16(sig[0]);
                            rx_blocks[0, 1] = Convert.ToInt16(sig[5] - sig[4]);
                            rx_blocks[0, 2] = 1;
                            int freq = Convert.ToInt32((sig[1]) * 1000);
                            int sr = Convert.ToInt32((sig[2] * 1000.0));

                            byte[] outStream = Encoding.ASCII.GetBytes("[GlobalMsg],Freq="+freq.ToString()+",Offset=9750000,Doppler=0,Srate="+sr.ToString()+",WideScan=0,LowSR=0,DVBmode=Auto,FPlug=A,Voltage=0,22kHz=Off\n");
                            IPAddress ip = System.Net.IPAddress.Parse("192.168.105.102");
                            int port = Convert.ToInt16("6789");
                            sending_end_point = new System.Net.IPEndPoint(ip, port);
                            MT_Client.Client.SendTo(outStream, sending_end_point);

                        udptimeout.Enabled = false;
                            ResetAll();
                        }
                    }
                }
        }

        private void ResetTS()
        {
            bitratetimer.Enabled = false;
            bitratetimer.Stop();
            Thread.Sleep(100);
            ts = null;
            ts = new TransportStream();
            ts.GetPsi().GetPmts().NewPMTEvent += NewPMTEvent;
            ts.GetPsi().GetSdt().NewSDTEvent += NewSDTEvent;
            ts.StartProcessing();
            bitratetimer.Enabled = true;
            bitratetimer.AutoReset = true;
            udptstimeout.Enabled = false;
            udptstimeout.Stop();
            SaveRec();
        }

        private void NewSDTEvent(object sender, SDTEventArgs e)
        {
            //Logger.Info("SDT INFO");

            foreach (SDTsection s in e._sections)
            {
                //Logger.Info(s);
                SDTsection.Service svc = s.GetServiceList()[0];

                //Logger.Info(svc);
                foreach (Descriptor d in svc.GetDescriptorList())
                {
                    //Logger.Info(" - " + d);
                    if (d is ServiceDescriptor)
                    {
                        ServiceDescriptor desc = (ServiceDescriptor) d;

                        lblServiceNamevalue.Invoke((MethodInvoker)delegate { lblServiceNamevalue.Text = desc.GetServiceName().ToString(); });
                        lblServiceProviderValue.Invoke((MethodInvoker)delegate { lblServiceProviderValue.Text = desc.GetServiceProviderName().ToString(); });
                    }
                }
                
                
            }
        }

        public float align_symbolrate(float width)
        {
            //console.log(width);
            if (width < 0.022)
            {
                return 0;
            }
            else if (width < 0.060)
            {
                return 0.035f;
            }
            else if (width < 0.086)
            {
                return 0.066f;
            }
            else if (width < 0.185)
            {
                return 0.125f;
            }
            else if (width < 0.277)
            {
                return 0.250f;
            }
            else if (width < 0.388)
            {
                return 0.333f;
            }
            else if (width < 0.700)
            {
                return 0.500f;
            }
            else if (width < 1.2)
            {
                return 1.000f;
            }
            else if (width < 1.6)
            {
                return 1.500f;
            }
            else if (width < 2.2)
            {
                return 2.000f;
            }
            else
            {
                return Convert.ToSingle(Math.Round(width * 5) / 5.0);
            }
        }



        public void detect_signals(UInt16[] fft_data)
        {
            lock (list_lock)
            {
                signals.Clear();
                int i;
                int j;

                int noise_level = 11000;
                int signal_threshold = 16000;

                Boolean in_signal = false;
                int start_signal = 0;
                int end_signal;
                float mid_signal;
                int strength_signal;
                float signal_bw;
                float signal_freq;
                int acc;
                int acc_i;




                for (i = 2; i < fft_data.Length; i++)
                {
                    if (!in_signal)
                    {
                        if ((fft_data[i] + fft_data[i - 1] + fft_data[i - 2]) / 3.0 > signal_threshold)
                        {
                            in_signal = true;
                            start_signal = i;
                        }
                    }
                    else /* in_signal == true */
                    {
                        if ((fft_data[i] + fft_data[i - 1] + fft_data[i - 2]) / 3.0 < signal_threshold)
                        {
                            in_signal = false;

                            end_signal = i;

                            acc = 0;
                            acc_i = 0;
                          
                            for (j = Convert.ToInt16(start_signal + (0.3 * (end_signal - start_signal))) | 0; j < start_signal + (0.7 * (end_signal - start_signal)); j++)
                            {
                                acc = acc + fft_data[j];
                                acc_i = acc_i + 1;
                            }

                            strength_signal = acc / acc_i;

                            /* Find real start of top of signal */
                            for (j = start_signal; (fft_data[j] - noise_level) < 0.75 * (strength_signal - noise_level); j++)
                            {
                                start_signal = j;
                            }


                            /* Find real end of the top of signal */
                            for (j = end_signal; (fft_data[j] - noise_level) < 0.75 * (strength_signal - noise_level); j--)
                            {
                                end_signal = j;
                            }
                          
                            mid_signal = Convert.ToSingle(start_signal + ((end_signal - start_signal) / 2.0));

                            signal_bw = align_symbolrate(Convert.ToSingle((end_signal - start_signal) * (9.0 / fft_data.Length)));
                            signal_freq = Convert.ToSingle(start_freq + (((mid_signal + 1) / fft_data.Length) * 9.0));

                            // Exclude signals in beacon band
                            if (signal_bw >= 0.033)
                            {
                                signals.Add(new List<double> { mid_signal, signal_freq, signal_bw, strength_signal / 255, start_signal, end_signal });

                            }
                        }
                    }
                }
            }

        }


        private void StopVideo()
        {
            if (playing)
            {
               _mediaPlayer.Stop();
                playing = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log4net.Repository.Hierarchy.Hierarchy rootRepo = (log4net.LogManager.GetRepository(Assembly.GetCallingAssembly()) as log4net.Repository.Hierarchy.Hierarchy);
            rootRepo.Root.Level = rootRepo.LevelMap["OFF"];

            //locked = true;
            StopVideo();

            ws.Close();
            udptimeout.Stop();
            udptstimeout.Stop();

            UdpMetaDataThreadRunning = false;
            UdpTSThreadRunning = false;
            bitratetimer.Stop();
            ts.StopProcessing();
            ts = null;
           
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!recording)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.CreatePrompt = true;
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.Title = "Save TS File";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "ts";
                saveFileDialog1.Filter = "TS files (*.ts)|*.ts";
                saveFileDialog1.FileName = lblServiceNamevalue.Text + "-" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".ts";
                //saveFileDialog1.FilterIndex = 2;
                //saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.ShowHelp = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnRecordTS.Text = "Recording";
                   // btnRecordTS.BackColor = Color.Red;
                    saveTSFilename = saveFileDialog1.FileName;
                }
                recording = true;
            } else
            {
                SaveRec();
            }
        }

        private void SaveRec()
        {
            recording = false;
            if (saveTSWriter != null)
            {
                saveTSWriter.Close();
            }
            saveTSWriter = null;
            btnRecordTS.Text = "Start Rec";

        }
    }
    // receive thread

    //FFT

}
