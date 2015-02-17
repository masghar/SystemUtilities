namespace NetworkUtil
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.outlook = new System.Windows.Forms.PictureBox();
            this.excel = new System.Windows.Forms.PictureBox();
            this.word = new System.Windows.Forms.PictureBox();
            this.notepad = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnAdapters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outlook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "                                 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // outlook
            // 
            this.outlook.Image = global::NetworkUtil.Properties.Resources.Outlook_icon;
            this.outlook.Location = new System.Drawing.Point(177, 12);
            this.outlook.Name = "outlook";
            this.outlook.Size = new System.Drawing.Size(49, 48);
            this.outlook.TabIndex = 7;
            this.outlook.TabStop = false;
            this.outlook.Click += new System.EventHandler(this.outlook_Click);
            // 
            // excel
            // 
            this.excel.Image = global::NetworkUtil.Properties.Resources.Excel_icon;
            this.excel.Location = new System.Drawing.Point(119, 12);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(49, 48);
            this.excel.TabIndex = 7;
            this.excel.TabStop = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // word
            // 
            this.word.Image = global::NetworkUtil.Properties.Resources.Word_icon;
            this.word.Location = new System.Drawing.Point(61, 12);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(49, 48);
            this.word.TabIndex = 7;
            this.word.TabStop = false;
            this.word.Click += new System.EventHandler(this.word_Click);
            // 
            // notepad
            // 
            this.notepad.Image = global::NetworkUtil.Properties.Resources.notepad_icon;
            this.notepad.Location = new System.Drawing.Point(3, 12);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(49, 48);
            this.notepad.TabIndex = 7;
            this.notepad.TabStop = false;
            this.notepad.Click += new System.EventHandler(this.notepad_Click);
            // 
            // button4
            // 
            this.button4.Image = global::NetworkUtil.Properties.Resources.Devices_yast_HD_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(23, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Device Manager";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::NetworkUtil.Properties.Resources.systempro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(23, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "System Properties";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::NetworkUtil.Properties.Resources.fire;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(23, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Windows Firewall";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::NetworkUtil.Properties.Resources.control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(23, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Control Panel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProxy
            // 
            this.btnProxy.Image = global::NetworkUtil.Properties.Resources.proxy;
            this.btnProxy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProxy.Location = new System.Drawing.Point(23, 122);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(191, 45);
            this.btnProxy.TabIndex = 0;
            this.btnProxy.Text = "Proxy Settings";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnAdapters
            // 
            this.btnAdapters.Image = global::NetworkUtil.Properties.Resources.adapters;
            this.btnAdapters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdapters.Location = new System.Drawing.Point(23, 77);
            this.btnAdapters.Name = "btnAdapters";
            this.btnAdapters.Size = new System.Drawing.Size(191, 45);
            this.btnAdapters.TabIndex = 0;
            this.btnAdapters.Text = "View Network Adapters";
            this.btnAdapters.UseVisualStyleBackColor = true;
            this.btnAdapters.Click += new System.EventHandler(this.btnAdapters_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(238, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outlook);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.word);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProxy);
            this.Controls.Add(this.btnAdapters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Utilities Shortcuts.";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outlook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notepad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdapters;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox notepad;
        private System.Windows.Forms.PictureBox word;
        private System.Windows.Forms.PictureBox excel;
        private System.Windows.Forms.PictureBox outlook;
        private System.Windows.Forms.Label label1;
    }
}

