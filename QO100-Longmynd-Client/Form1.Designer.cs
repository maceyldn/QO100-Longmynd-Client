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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.ledBulb1 = new Bulb.LedBulb();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal/TS Info";
            // 
            // lblDVBtypevalue
            // 
            this.lblDVBtypevalue.AutoSize = true;
            this.lblDVBtypevalue.Location = new System.Drawing.Point(248, 64);
            this.lblDVBtypevalue.Name = "lblDVBtypevalue";
            this.lblDVBtypevalue.Size = new System.Drawing.Size(28, 17);
            this.lblDVBtypevalue.TabIndex = 12;
            this.lblDVBtypevalue.Text = ".... ";
            // 
            // lblMODTypevalue
            // 
            this.lblMODTypevalue.AutoSize = true;
            this.lblMODTypevalue.Location = new System.Drawing.Point(248, 81);
            this.lblMODTypevalue.Name = "lblMODTypevalue";
            this.lblMODTypevalue.Size = new System.Drawing.Size(28, 17);
            this.lblMODTypevalue.TabIndex = 11;
            this.lblMODTypevalue.Text = ".... ";
            // 
            // lblStatusvalue
            // 
            this.lblStatusvalue.AutoSize = true;
            this.lblStatusvalue.Location = new System.Drawing.Point(248, 30);
            this.lblStatusvalue.Name = "lblStatusvalue";
            this.lblStatusvalue.Size = new System.Drawing.Size(28, 17);
            this.lblStatusvalue.TabIndex = 10;
            this.lblStatusvalue.Text = ".... ";
            // 
            // lblPercentNullvalue
            // 
            this.lblPercentNullvalue.AutoSize = true;
            this.lblPercentNullvalue.Location = new System.Drawing.Point(145, 98);
            this.lblPercentNullvalue.Name = "lblPercentNullvalue";
            this.lblPercentNullvalue.Size = new System.Drawing.Size(28, 17);
            this.lblPercentNullvalue.TabIndex = 9;
            this.lblPercentNullvalue.Text = ".... ";
            // 
            // lblPercentNull
            // 
            this.lblPercentNull.AutoSize = true;
            this.lblPercentNull.Location = new System.Drawing.Point(19, 98);
            this.lblPercentNull.Name = "lblPercentNull";
            this.lblPercentNull.Size = new System.Drawing.Size(52, 17);
            this.lblPercentNull.TabIndex = 8;
            this.lblPercentNull.Text = "% Null:";
            // 
            // lblBERvalue
            // 
            this.lblBERvalue.AutoSize = true;
            this.lblBERvalue.Location = new System.Drawing.Point(145, 81);
            this.lblBERvalue.Name = "lblBERvalue";
            this.lblBERvalue.Size = new System.Drawing.Size(28, 17);
            this.lblBERvalue.TabIndex = 7;
            this.lblBERvalue.Text = ".... ";
            // 
            // lblMERvalue
            // 
            this.lblMERvalue.AutoSize = true;
            this.lblMERvalue.Location = new System.Drawing.Point(145, 64);
            this.lblMERvalue.Name = "lblMERvalue";
            this.lblMERvalue.Size = new System.Drawing.Size(28, 17);
            this.lblMERvalue.TabIndex = 6;
            this.lblMERvalue.Text = ".... ";
            // 
            // lblServiceNamevalue
            // 
            this.lblServiceNamevalue.AutoSize = true;
            this.lblServiceNamevalue.Location = new System.Drawing.Point(145, 47);
            this.lblServiceNamevalue.Name = "lblServiceNamevalue";
            this.lblServiceNamevalue.Size = new System.Drawing.Size(28, 17);
            this.lblServiceNamevalue.TabIndex = 5;
            this.lblServiceNamevalue.Text = ".... ";
            // 
            // lblServiceProviderValue
            // 
            this.lblServiceProviderValue.AutoSize = true;
            this.lblServiceProviderValue.Location = new System.Drawing.Point(145, 30);
            this.lblServiceProviderValue.Name = "lblServiceProviderValue";
            this.lblServiceProviderValue.Size = new System.Drawing.Size(28, 17);
            this.lblServiceProviderValue.TabIndex = 4;
            this.lblServiceProviderValue.Text = ".... ";
            // 
            // lblBER
            // 
            this.lblBER.AutoSize = true;
            this.lblBER.Location = new System.Drawing.Point(19, 81);
            this.lblBER.Name = "lblBER";
            this.lblBER.Size = new System.Drawing.Size(44, 17);
            this.lblBER.TabIndex = 3;
            this.lblBER.Text = "BER: ";
            // 
            // lblMER
            // 
            this.lblMER.AutoSize = true;
            this.lblMER.Location = new System.Drawing.Point(19, 64);
            this.lblMER.Name = "lblMER";
            this.lblMER.Size = new System.Drawing.Size(46, 17);
            this.lblMER.TabIndex = 2;
            this.lblMER.Text = "MER: ";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(19, 47);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(104, 17);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "Service Name: ";
            // 
            // lblServiceProvider
            // 
            this.lblServiceProvider.AutoSize = true;
            this.lblServiceProvider.Location = new System.Drawing.Point(19, 30);
            this.lblServiceProvider.Name = "lblServiceProvider";
            this.lblServiceProvider.Size = new System.Drawing.Size(120, 17);
            this.lblServiceProvider.TabIndex = 0;
            this.lblServiceProvider.Text = "Service Provider: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1014);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1109, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
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
            this.menuStrip1.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.axVLCPlugin21);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1080, 789);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live View";
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Top;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(3, 18);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(1074, 488);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // ledBulb1
            // 
            this.ledBulb1.Color = System.Drawing.Color.White;
            this.ledBulb1.Location = new System.Drawing.Point(362, 30);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(76, 75);
            this.ledBulb1.TabIndex = 13;
            this.ledBulb1.Text = "ledBulb1";
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
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 1040);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private Bulb.LedBulb ledBulb1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

