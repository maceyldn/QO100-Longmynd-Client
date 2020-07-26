using AXVLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QO100LongmyndClient
{
    public partial class Form1 : Form
    {
        private const int port = 5001;
        public UdpClient client;
        public String state;
        public bool dvbs2 = false;
        Dictionary<int, String> DVBSLookup = new Dictionary<int, string>();
        Dictionary<int, String> DVBS2Lookup = new Dictionary<int, string>();
        bool playing = false;
        private WebSocket ws;
        Thread UdpThread;


        public Form1()
        {
            InitializeComponent();

            //this.FormClosing += Form1_FormClosing;
            //Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

           UdpThread = new Thread(ReceiveData);
            UdpThread.Start();

        }

        public void ReceiveData()
        {
            client = new UdpClient();

            IPEndPoint localEp = new IPEndPoint(IPAddress.Any, port);
            client.Client.Bind(localEp);

            //client.JoinMulticastGroup(IPAddress.Parse(MULTICAST_ADDR));
            while (true)
            {
                try
                {
                    byte[] data = client.Receive(ref localEp);
                    string text = Encoding.UTF8.GetString(data).TrimStart('$');
                    string[] message = text.Split(',');
                    //Chop "@" from start.
                    Process(message);


                    //Console.WriteLine(text);
                }
                catch (Exception err)
                {
                    //Console.WriteLine(err.ToString());
                }
            }
        }



        private void Process(string[] message)
        {
            //       LongMyndStatus t;
            switch (message[0])
            {
                case "1":
                    Console.Write(message[1]);
                    switch (message[1].TrimEnd('\n'))
                    {
                        case "0":
                            state = "Initialising...";
                            ledBulb1.Color = Color.Red;
                            StopVideo();
                            break;
                        case "1":
                            state = "Searching...";
                            ledBulb1.Color = Color.Red;
                            StopVideo();
                            break;
                        case "2":
                            state = "Found Headers...";
                            ledBulb1.Color = Color.Red;
                            StopVideo();
                            break;
                        case "3":
                            state = "Locked DVB-S...";
                            dvbs2 = false;
                            ledBulb1.Color = Color.Green;
                            ShowVideo();
                            break;
                        case "4":
                            state = "Locked DVB-S2...";
                            ledBulb1.Color = Color.Green;
                            ShowVideo();
                            dvbs2 = true;
                            break;
                        default:
                            state = "Unknown";
                            ledBulb1.Color = Color.Red;
                            break;
                    }
                    lblStatusvalue.Invoke((MethodInvoker)delegate { lblStatusvalue.Text = state; });

                    if (dvbs2)
                    {
                        lblDVBtypevalue.Invoke((MethodInvoker)delegate { lblDVBtypevalue.Text = "DVB-S2"; });
                    } else
                    {
                        lblMODTypevalue.Invoke((MethodInvoker)delegate { lblMODTypevalue.Text = "DVB-S"; });
                    }
                    break;
                case "11":
                    lblBERvalue.Invoke((MethodInvoker)delegate { lblBERvalue.Text = message[1]; });
                    break;
                case "12":
                    lblMERvalue.Invoke((MethodInvoker)delegate { lblMERvalue.Text = message[1]; });
                    break;
                case "13":
                    lblServiceProviderValue.Invoke((MethodInvoker)delegate { lblServiceProviderValue.Text = message[1]; });
                    break;
                case "14":
                    lblServiceNamevalue.Invoke((MethodInvoker)delegate { lblServiceNamevalue.Text = message[1]; });
                    break;
                case "15":
                    lblPercentNullvalue.Invoke((MethodInvoker)delegate { lblPercentNullvalue.Text = message[1]; });
                    break;
                case "18":
                    if (!dvbs2)
                    {
                        String value;
                        DVBSLookup.TryGetValue(int.Parse(message[1]), out value);
                        lblMODTypevalue.Invoke((MethodInvoker)delegate { lblMODTypevalue.Text = value; });
                    } else
                    {
                        String value;
                        DVBS2Lookup.TryGetValue(int.Parse(message[1]), out value);
                        lblMODTypevalue.Invoke((MethodInvoker)delegate { lblMODTypevalue.Text = value; });
                    }

                    break;

                default:
                    break;
            }
        }

        private void ShowVideo()
        {
            if (!playing)
            {
                axVLCPlugin21.playlist.items.clear();
                axVLCPlugin21.playlist.add("udp://@:5000");
                axVLCPlugin21.playlist.play();
                playing = true;
            }
        }

        private void StopVideo()
        {
            if (playing)
            {
                axVLCPlugin21.playlist.items.clear();
                axVLCPlugin21.playlist.stop();
                playing = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UdpThread.Abort();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    // receive thread

    //FFT

}
