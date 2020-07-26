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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledBulb1 = new Bulb.LedBulb();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSpectrum = new System.Windows.Forms.PictureBox();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblcodecvalue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCodec = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledBulb1);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(333, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal/TS Info";
            // 
            // ledBulb1
            // 
            this.ledBulb1.Color = System.Drawing.Color.White;
            this.ledBulb1.Location = new System.Drawing.Point(273, 46);
            this.ledBulb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(57, 61);
            this.ledBulb1.TabIndex = 13;
            this.ledBulb1.Text = "ledBulb1";
            // 
            // lblDVBtypevalue
            // 
            this.lblDVBtypevalue.AutoSize = true;
            this.lblDVBtypevalue.Location = new System.Drawing.Point(186, 52);
            this.lblDVBtypevalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDVBtypevalue.Name = "lblDVBtypevalue";
            this.lblDVBtypevalue.Size = new System.Drawing.Size(22, 13);
            this.lblDVBtypevalue.TabIndex = 12;
            this.lblDVBtypevalue.Text = ".... ";
            // 
            // lblMODTypevalue
            // 
            this.lblMODTypevalue.AutoSize = true;
            this.lblMODTypevalue.Location = new System.Drawing.Point(186, 66);
            this.lblMODTypevalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMODTypevalue.Name = "lblMODTypevalue";
            this.lblMODTypevalue.Size = new System.Drawing.Size(22, 13);
            this.lblMODTypevalue.TabIndex = 11;
            this.lblMODTypevalue.Text = ".... ";
            // 
            // lblStatusvalue
            // 
            this.lblStatusvalue.AutoSize = true;
            this.lblStatusvalue.Location = new System.Drawing.Point(186, 24);
            this.lblStatusvalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusvalue.Name = "lblStatusvalue";
            this.lblStatusvalue.Size = new System.Drawing.Size(22, 13);
            this.lblStatusvalue.TabIndex = 10;
            this.lblStatusvalue.Text = ".... ";
            // 
            // lblPercentNullvalue
            // 
            this.lblPercentNullvalue.AutoSize = true;
            this.lblPercentNullvalue.Location = new System.Drawing.Point(109, 80);
            this.lblPercentNullvalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentNullvalue.Name = "lblPercentNullvalue";
            this.lblPercentNullvalue.Size = new System.Drawing.Size(22, 13);
            this.lblPercentNullvalue.TabIndex = 9;
            this.lblPercentNullvalue.Text = ".... ";
            // 
            // lblPercentNull
            // 
            this.lblPercentNull.AutoSize = true;
            this.lblPercentNull.Location = new System.Drawing.Point(14, 80);
            this.lblPercentNull.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentNull.Name = "lblPercentNull";
            this.lblPercentNull.Size = new System.Drawing.Size(39, 13);
            this.lblPercentNull.TabIndex = 8;
            this.lblPercentNull.Text = "% Null:";
            // 
            // lblBERvalue
            // 
            this.lblBERvalue.AutoSize = true;
            this.lblBERvalue.Location = new System.Drawing.Point(109, 66);
            this.lblBERvalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBERvalue.Name = "lblBERvalue";
            this.lblBERvalue.Size = new System.Drawing.Size(22, 13);
            this.lblBERvalue.TabIndex = 7;
            this.lblBERvalue.Text = ".... ";
            // 
            // lblMERvalue
            // 
            this.lblMERvalue.AutoSize = true;
            this.lblMERvalue.Location = new System.Drawing.Point(109, 52);
            this.lblMERvalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMERvalue.Name = "lblMERvalue";
            this.lblMERvalue.Size = new System.Drawing.Size(22, 13);
            this.lblMERvalue.TabIndex = 6;
            this.lblMERvalue.Text = ".... ";
            // 
            // lblServiceNamevalue
            // 
            this.lblServiceNamevalue.AutoSize = true;
            this.lblServiceNamevalue.Location = new System.Drawing.Point(109, 38);
            this.lblServiceNamevalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceNamevalue.Name = "lblServiceNamevalue";
            this.lblServiceNamevalue.Size = new System.Drawing.Size(22, 13);
            this.lblServiceNamevalue.TabIndex = 5;
            this.lblServiceNamevalue.Text = ".... ";
            // 
            // lblServiceProviderValue
            // 
            this.lblServiceProviderValue.AutoSize = true;
            this.lblServiceProviderValue.Location = new System.Drawing.Point(109, 24);
            this.lblServiceProviderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceProviderValue.Name = "lblServiceProviderValue";
            this.lblServiceProviderValue.Size = new System.Drawing.Size(22, 13);
            this.lblServiceProviderValue.TabIndex = 4;
            this.lblServiceProviderValue.Text = ".... ";
            // 
            // lblBER
            // 
            this.lblBER.AutoSize = true;
            this.lblBER.Location = new System.Drawing.Point(14, 66);
            this.lblBER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBER.Name = "lblBER";
            this.lblBER.Size = new System.Drawing.Size(35, 13);
            this.lblBER.TabIndex = 3;
            this.lblBER.Text = "BER: ";
            // 
            // lblMER
            // 
            this.lblMER.AutoSize = true;
            this.lblMER.Location = new System.Drawing.Point(14, 52);
            this.lblMER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMER.Name = "lblMER";
            this.lblMER.Size = new System.Drawing.Size(37, 13);
            this.lblMER.TabIndex = 2;
            this.lblMER.Text = "MER: ";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(14, 38);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(80, 13);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "Service Name: ";
            // 
            // lblServiceProvider
            // 
            this.lblServiceProvider.AutoSize = true;
            this.lblServiceProvider.Location = new System.Drawing.Point(14, 24);
            this.lblServiceProvider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceProvider.Name = "lblServiceProvider";
            this.lblServiceProvider.Size = new System.Drawing.Size(91, 13);
            this.lblServiceProvider.TabIndex = 0;
            this.lblServiceProvider.Text = "Service Provider: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // pbSpectrum
            // 
            this.pbSpectrum.BackColor = System.Drawing.Color.Black;
            this.pbSpectrum.Location = new System.Drawing.Point(0, 394);
            this.pbSpectrum.Margin = new System.Windows.Forms.Padding(0);
            this.pbSpectrum.Name = "pbSpectrum";
            this.pbSpectrum.Size = new System.Drawing.Size(921, 219);
            this.pbSpectrum.TabIndex = 2;
            this.pbSpectrum.TabStop = false;
            this.pbSpectrum.Click += new System.EventHandler(this.spectrum_Click);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(347, 35);
            this.axVLCPlugin21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(573, 354);
            this.axVLCPlugin21.TabIndex = 3;
            this.axVLCPlugin21.MediaPlayerPlaying += new System.EventHandler(this.axVLCPlugin21_MediaPlayerPlaying);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblcodecvalue);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblCodec);
            this.groupBox2.Location = new System.Drawing.Point(3, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(333, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Codec Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = ".... ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = ".... ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = ".... ";
            // 
            // lblcodecvalue
            // 
            this.lblcodecvalue.AutoSize = true;
            this.lblcodecvalue.Location = new System.Drawing.Point(109, 24);
            this.lblcodecvalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodecvalue.Name = "lblcodecvalue";
            this.lblcodecvalue.Size = new System.Drawing.Size(22, 13);
            this.lblcodecvalue.TabIndex = 4;
            this.lblcodecvalue.Text = ".... ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Audio Bitrate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Audio Codec:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Video Bitrate: ";
            // 
            // lblCodec
            // 
            this.lblCodec.AutoSize = true;
            this.lblCodec.Location = new System.Drawing.Point(14, 24);
            this.lblCodec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodec.Name = "lblCodec";
            this.lblCodec.Size = new System.Drawing.Size(71, 13);
            this.lblCodec.TabIndex = 0;
            this.lblCodec.Text = "Video Codec:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.pbSpectrum);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "QO100-Longmynd-Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblBER;
        private System.Windows.Forms.Label lblMER;
        private System.Windows.Forms.Label lblBERvalue;
        private System.Windows.Forms.Label lblMERvalue;
        private System.Windows.Forms.Label lblServiceNamevalue;
        private System.Windows.Forms.Label lblServiceProviderValue;
        private System.Windows.Forms.Label lblPercentNullvalue;
        private System.Windows.Forms.Label lblPercentNull;
        private System.Windows.Forms.Label lblStatusvalue;
        private System.Windows.Forms.Label lblMODTypevalue;
        private System.Windows.Forms.Label lblDVBtypevalue;
        private Bulb.LedBulb ledBulb1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbSpectrum;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblcodecvalue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCodec;
    }
}

