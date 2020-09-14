namespace QO100LongmyndClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                ts = null;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRecordTS = new System.Windows.Forms.Button();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblabitratevalue = new System.Windows.Forms.Label();
            this.lblaudiocodec = new System.Windows.Forms.Label();
            this.lblvbitratevalue = new System.Windows.Forms.Label();
            this.lblcodecvalue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCodec = new System.Windows.Forms.Label();
            this.pbSpectrum = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledBulb2 = new Bulb.LedBulb();
            this.ledBulb1 = new Bulb.LedBulb();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBitratevalue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDVBtypevalue = new System.Windows.Forms.Label();
            this.lblMODTypevalue = new System.Windows.Forms.Label();
            this.lblStatusvalue = new System.Windows.Forms.Label();
            this.lblPercentNullvalue = new System.Windows.Forms.Label();
            this.lblPercentNull = new System.Windows.Forms.Label();
            this.lblBERvalue = new System.Windows.Forms.Label();
            this.lblMERvalue = new System.Windows.Forms.Label();
            this.lblServiceNamevalue = new System.Windows.Forms.Label();
            this.lblServiceProviderValue = new System.Windows.Forms.Label();
            this.lblBER = new System.Windows.Forms.Label();
            this.lblMER = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServiceProvider = new System.Windows.Forms.Label();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbTSLog = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpectrum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 979);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1181, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpConfig);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1186, 946);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRecordTS);
            this.tabPage1.Controls.Add(this.videoView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.pbSpectrum);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1178, 913);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRecordTS
            // 
            this.btnRecordTS.Location = new System.Drawing.Point(351, 561);
            this.btnRecordTS.Name = "btnRecordTS";
            this.btnRecordTS.Size = new System.Drawing.Size(94, 29);
            this.btnRecordTS.TabIndex = 10;
            this.btnRecordTS.Text = "Record TS";
            this.btnRecordTS.UseVisualStyleBackColor = true;
            this.btnRecordTS.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Location = new System.Drawing.Point(454, 17);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(720, 576);
            this.videoView1.TabIndex = 9;
            this.videoView1.Text = "videoView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblabitratevalue);
            this.groupBox2.Controls.Add(this.lblaudiocodec);
            this.groupBox2.Controls.Add(this.lblvbitratevalue);
            this.groupBox2.Controls.Add(this.lblcodecvalue);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblCodec);
            this.groupBox2.Location = new System.Drawing.Point(3, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(444, 275);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codec Info";
            // 
            // lblabitratevalue
            // 
            this.lblabitratevalue.AutoSize = true;
            this.lblabitratevalue.Location = new System.Drawing.Point(145, 158);
            this.lblabitratevalue.Name = "lblabitratevalue";
            this.lblabitratevalue.Size = new System.Drawing.Size(25, 20);
            this.lblabitratevalue.TabIndex = 7;
            this.lblabitratevalue.Text = ".... ";
            // 
            // lblaudiocodec
            // 
            this.lblaudiocodec.Location = new System.Drawing.Point(145, 101);
            this.lblaudiocodec.Name = "lblaudiocodec";
            this.lblaudiocodec.Size = new System.Drawing.Size(293, 56);
            this.lblaudiocodec.TabIndex = 6;
            this.lblaudiocodec.Text = ".... ";
            // 
            // lblvbitratevalue
            // 
            this.lblvbitratevalue.AutoSize = true;
            this.lblvbitratevalue.Location = new System.Drawing.Point(145, 81);
            this.lblvbitratevalue.Name = "lblvbitratevalue";
            this.lblvbitratevalue.Size = new System.Drawing.Size(25, 20);
            this.lblvbitratevalue.TabIndex = 5;
            this.lblvbitratevalue.Text = ".... ";
            // 
            // lblcodecvalue
            // 
            this.lblcodecvalue.Location = new System.Drawing.Point(145, 38);
            this.lblcodecvalue.Name = "lblcodecvalue";
            this.lblcodecvalue.Size = new System.Drawing.Size(293, 41);
            this.lblcodecvalue.TabIndex = 4;
            this.lblcodecvalue.Text = ".... ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Audio Bitrate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Audio Codec:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Video Bitrate: ";
            // 
            // lblCodec
            // 
            this.lblCodec.AutoSize = true;
            this.lblCodec.Location = new System.Drawing.Point(19, 38);
            this.lblCodec.Name = "lblCodec";
            this.lblCodec.Size = new System.Drawing.Size(97, 20);
            this.lblCodec.TabIndex = 0;
            this.lblCodec.Text = "Video Codec:";
            // 
            // pbSpectrum
            // 
            this.pbSpectrum.BackColor = System.Drawing.Color.Black;
            this.pbSpectrum.Location = new System.Drawing.Point(-4, 598);
            this.pbSpectrum.Margin = new System.Windows.Forms.Padding(0);
            this.pbSpectrum.Name = "pbSpectrum";
            this.pbSpectrum.Size = new System.Drawing.Size(1178, 313);
            this.pbSpectrum.TabIndex = 6;
            this.pbSpectrum.TabStop = false;
            this.pbSpectrum.Click += new System.EventHandler(this.spectrum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledBulb2);
            this.groupBox1.Controls.Add(this.ledBulb1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalBitratevalue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDVBtypevalue);
            this.groupBox1.Controls.Add(this.lblMODTypevalue);
            this.groupBox1.Controls.Add(this.lblStatusvalue);
            this.groupBox1.Controls.Add(this.lblPercentNullvalue);
            this.groupBox1.Controls.Add(this.lblPercentNull);
            this.groupBox1.Controls.Add(this.lblBERvalue);
            this.groupBox1.Controls.Add(this.lblMERvalue);
            this.groupBox1.Controls.Add(this.lblServiceNamevalue);
            this.groupBox1.Controls.Add(this.lblServiceProviderValue);
            this.groupBox1.Controls.Add(this.lblBER);
            this.groupBox1.Controls.Add(this.lblMER);
            this.groupBox1.Controls.Add(this.lblServiceName);
            this.groupBox1.Controls.Add(this.lblServiceProvider);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(444, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal/TS Info";
            // 
            // ledBulb2
            // 
            this.ledBulb2.Color = System.Drawing.Color.Red;
            this.ledBulb2.Location = new System.Drawing.Point(413, 121);
            this.ledBulb2.Name = "ledBulb2";
            this.ledBulb2.On = true;
            this.ledBulb2.Size = new System.Drawing.Size(30, 27);
            this.ledBulb2.TabIndex = 16;
            this.ledBulb2.Text = "ledBulb2";
            // 
            // ledBulb1
            // 
            this.ledBulb1.Color = System.Drawing.Color.Red;
            this.ledBulb1.Location = new System.Drawing.Point(370, 121);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(30, 27);
            this.ledBulb1.TabIndex = 16;
            this.ledBulb1.Text = "ledBulb1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Demod  |  TS";
            // 
            // lblTotalBitratevalue
            // 
            this.lblTotalBitratevalue.AutoSize = true;
            this.lblTotalBitratevalue.Location = new System.Drawing.Point(145, 142);
            this.lblTotalBitratevalue.Name = "lblTotalBitratevalue";
            this.lblTotalBitratevalue.Size = new System.Drawing.Size(25, 20);
            this.lblTotalBitratevalue.TabIndex = 15;
            this.lblTotalBitratevalue.Text = ".... ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Bitrate:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDVBtypevalue
            // 
            this.lblDVBtypevalue.AutoSize = true;
            this.lblDVBtypevalue.Location = new System.Drawing.Point(248, 80);
            this.lblDVBtypevalue.Name = "lblDVBtypevalue";
            this.lblDVBtypevalue.Size = new System.Drawing.Size(25, 20);
            this.lblDVBtypevalue.TabIndex = 12;
            this.lblDVBtypevalue.Text = ".... ";
            // 
            // lblMODTypevalue
            // 
            this.lblMODTypevalue.AutoSize = true;
            this.lblMODTypevalue.Location = new System.Drawing.Point(248, 101);
            this.lblMODTypevalue.Name = "lblMODTypevalue";
            this.lblMODTypevalue.Size = new System.Drawing.Size(25, 20);
            this.lblMODTypevalue.TabIndex = 11;
            this.lblMODTypevalue.Text = ".... ";
            // 
            // lblStatusvalue
            // 
            this.lblStatusvalue.AutoSize = true;
            this.lblStatusvalue.Location = new System.Drawing.Point(248, 38);
            this.lblStatusvalue.Name = "lblStatusvalue";
            this.lblStatusvalue.Size = new System.Drawing.Size(25, 20);
            this.lblStatusvalue.TabIndex = 10;
            this.lblStatusvalue.Text = ".... ";
            // 
            // lblPercentNullvalue
            // 
            this.lblPercentNullvalue.AutoSize = true;
            this.lblPercentNullvalue.Location = new System.Drawing.Point(145, 122);
            this.lblPercentNullvalue.Name = "lblPercentNullvalue";
            this.lblPercentNullvalue.Size = new System.Drawing.Size(25, 20);
            this.lblPercentNullvalue.TabIndex = 9;
            this.lblPercentNullvalue.Text = ".... ";
            // 
            // lblPercentNull
            // 
            this.lblPercentNull.AutoSize = true;
            this.lblPercentNull.Location = new System.Drawing.Point(19, 122);
            this.lblPercentNull.Name = "lblPercentNull";
            this.lblPercentNull.Size = new System.Drawing.Size(39, 20);
            this.lblPercentNull.TabIndex = 8;
            this.lblPercentNull.Text = "Null:";
            // 
            // lblBERvalue
            // 
            this.lblBERvalue.AutoSize = true;
            this.lblBERvalue.Location = new System.Drawing.Point(145, 101);
            this.lblBERvalue.Name = "lblBERvalue";
            this.lblBERvalue.Size = new System.Drawing.Size(25, 20);
            this.lblBERvalue.TabIndex = 7;
            this.lblBERvalue.Text = ".... ";
            // 
            // lblMERvalue
            // 
            this.lblMERvalue.AutoSize = true;
            this.lblMERvalue.Location = new System.Drawing.Point(145, 80);
            this.lblMERvalue.Name = "lblMERvalue";
            this.lblMERvalue.Size = new System.Drawing.Size(25, 20);
            this.lblMERvalue.TabIndex = 6;
            this.lblMERvalue.Text = ".... ";
            // 
            // lblServiceNamevalue
            // 
            this.lblServiceNamevalue.AutoSize = true;
            this.lblServiceNamevalue.Location = new System.Drawing.Point(145, 59);
            this.lblServiceNamevalue.Name = "lblServiceNamevalue";
            this.lblServiceNamevalue.Size = new System.Drawing.Size(25, 20);
            this.lblServiceNamevalue.TabIndex = 5;
            this.lblServiceNamevalue.Text = ".... ";
            // 
            // lblServiceProviderValue
            // 
            this.lblServiceProviderValue.AutoSize = true;
            this.lblServiceProviderValue.Location = new System.Drawing.Point(145, 38);
            this.lblServiceProviderValue.Name = "lblServiceProviderValue";
            this.lblServiceProviderValue.Size = new System.Drawing.Size(25, 20);
            this.lblServiceProviderValue.TabIndex = 4;
            this.lblServiceProviderValue.Text = ".... ";
            // 
            // lblBER
            // 
            this.lblBER.AutoSize = true;
            this.lblBER.Location = new System.Drawing.Point(19, 101);
            this.lblBER.Name = "lblBER";
            this.lblBER.Size = new System.Drawing.Size(42, 20);
            this.lblBER.TabIndex = 3;
            this.lblBER.Text = "BER: ";
            // 
            // lblMER
            // 
            this.lblMER.AutoSize = true;
            this.lblMER.Location = new System.Drawing.Point(19, 80);
            this.lblMER.Name = "lblMER";
            this.lblMER.Size = new System.Drawing.Size(46, 20);
            this.lblMER.TabIndex = 2;
            this.lblMER.Text = "MER: ";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(19, 59);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(107, 20);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "Service Name: ";
            // 
            // lblServiceProvider
            // 
            this.lblServiceProvider.AutoSize = true;
            this.lblServiceProvider.Location = new System.Drawing.Point(19, 38);
            this.lblServiceProvider.Name = "lblServiceProvider";
            this.lblServiceProvider.Size = new System.Drawing.Size(122, 20);
            this.lblServiceProvider.TabIndex = 0;
            this.lblServiceProvider.Text = "Service Provider: ";
            // 
            // tpConfig
            // 
            this.tpConfig.Location = new System.Drawing.Point(4, 29);
            this.tpConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Size = new System.Drawing.Size(1178, 913);
            this.tpConfig.TabIndex = 2;
            this.tpConfig.Text = "Config";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbTSLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1178, 913);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "TS Log";
            // 
            // tbTSLog
            // 
            this.tbTSLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTSLog.Location = new System.Drawing.Point(0, 0);
            this.tbTSLog.Multiline = true;
            this.tbTSLog.Name = "tbTSLog";
            this.tbTSLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTSLog.Size = new System.Drawing.Size(1178, 913);
            this.tbTSLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1181, 1005);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QO100-Longmynd-Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpectrum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblabitratevalue;
        private System.Windows.Forms.Label lblaudiocodec;
        private System.Windows.Forms.Label lblvbitratevalue;
        private System.Windows.Forms.Label lblcodecvalue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCodec;
        private System.Windows.Forms.PictureBox pbSpectrum;
        private System.Windows.Forms.GroupBox groupBox1;
        
        private System.Windows.Forms.Label lblDVBtypevalue;
        private System.Windows.Forms.Label lblMODTypevalue;
        private System.Windows.Forms.Label lblStatusvalue;
        private System.Windows.Forms.Label lblPercentNullvalue;
        private System.Windows.Forms.Label lblPercentNull;
        private System.Windows.Forms.Label lblBERvalue;
        private System.Windows.Forms.Label lblMERvalue;
        private System.Windows.Forms.Label lblServiceNamevalue;
        private System.Windows.Forms.Label lblServiceProviderValue;
        private System.Windows.Forms.Label lblBER;
        private System.Windows.Forms.Label lblMER;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceProvider;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.Label lblTotalBitratevalue;
        private System.Windows.Forms.Label label2;
      
        private LibVLCSharp.WinForms.VideoView videoView1;
        private System.Windows.Forms.Button btnRecordTS;
        private System.Windows.Forms.Label label1;
        private Bulb.LedBulb ledBulb2;
        private Bulb.LedBulb ledBulb1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbTSLog;
    }
}

