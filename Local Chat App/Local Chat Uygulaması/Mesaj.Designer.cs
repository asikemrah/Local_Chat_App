namespace Local_Chat_Uygulaması
{
    partial class Mesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesaj));
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclientIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtclientPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtserverPort = new System.Windows.Forms.TextBox();
            this.txtserverIP = new System.Windows.Forms.TextBox();
            this.btnFileTransfer = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtMesaj = new ns1.BunifuMaterialTextbox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnBaslat);
            this.bunifuGradientPanel1.Controls.Add(this.btnBaglan);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox2);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnFileTransfer);
            this.bunifuGradientPanel1.Controls.Add(this.btnAyarlar);
            this.bunifuGradientPanel1.Controls.Add(this.btnGonder);
            this.bunifuGradientPanel1.Controls.Add(this.txtMesaj);
            this.bunifuGradientPanel1.Controls.Add(this.lbChat);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 538);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.Transparent;
            this.btnBaslat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBaslat.FlatAppearance.BorderSize = 0;
            this.btnBaslat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBaslat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Image = ((System.Drawing.Image)(resources.GetObject("btnBaslat.Image")));
            this.btnBaslat.Location = new System.Drawing.Point(331, 52);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(54, 43);
            this.btnBaslat.TabIndex = 17;
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.Color.Transparent;
            this.btnBaglan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBaglan.FlatAppearance.BorderSize = 0;
            this.btnBaglan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBaglan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglan.Image")));
            this.btnBaglan.Location = new System.Drawing.Point(730, 52);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(54, 43);
            this.btnBaglan.TabIndex = 16;
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtclientIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtclientPort);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(417, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port";
            // 
            // txtclientIP
            // 
            this.txtclientIP.Location = new System.Drawing.Point(58, 18);
            this.txtclientIP.Multiline = true;
            this.txtclientIP.Name = "txtclientIP";
            this.txtclientIP.Size = new System.Drawing.Size(236, 28);
            this.txtclientIP.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP";
            // 
            // txtclientPort
            // 
            this.txtclientPort.Location = new System.Drawing.Point(58, 56);
            this.txtclientPort.Multiline = true;
            this.txtclientPort.Name = "txtclientPort";
            this.txtclientPort.Size = new System.Drawing.Size(236, 28);
            this.txtclientPort.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtserverPort);
            this.groupBox1.Controls.Add(this.txtserverIP);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // txtserverPort
            // 
            this.txtserverPort.Location = new System.Drawing.Point(58, 56);
            this.txtserverPort.Multiline = true;
            this.txtserverPort.Name = "txtserverPort";
            this.txtserverPort.Size = new System.Drawing.Size(236, 28);
            this.txtserverPort.TabIndex = 1;
            // 
            // txtserverIP
            // 
            this.txtserverIP.Location = new System.Drawing.Point(58, 18);
            this.txtserverIP.Multiline = true;
            this.txtserverIP.Name = "txtserverIP";
            this.txtserverIP.Size = new System.Drawing.Size(236, 28);
            this.txtserverIP.TabIndex = 0;
            // 
            // btnFileTransfer
            // 
            this.btnFileTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnFileTransfer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFileTransfer.FlatAppearance.BorderSize = 0;
            this.btnFileTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFileTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFileTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnFileTransfer.Image")));
            this.btnFileTransfer.Location = new System.Drawing.Point(615, 485);
            this.btnFileTransfer.Name = "btnFileTransfer";
            this.btnFileTransfer.Size = new System.Drawing.Size(54, 43);
            this.btnFileTransfer.TabIndex = 13;
            this.btnFileTransfer.UseVisualStyleBackColor = false;
            this.btnFileTransfer.Click += new System.EventHandler(this.btnFileTransfer_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.Location = new System.Drawing.Point(675, 486);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(54, 43);
            this.btnAyarlar.TabIndex = 12;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Transparent;
            this.btnGonder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGonder.FlatAppearance.BorderSize = 0;
            this.btnGonder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGonder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.Image")));
            this.btnGonder.Location = new System.Drawing.Point(735, 486);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(54, 43);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.BackColor = System.Drawing.Color.White;
            this.txtMesaj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMesaj.HintForeColor = System.Drawing.Color.Empty;
            this.txtMesaj.HintText = "";
            this.txtMesaj.isPassword = false;
            this.txtMesaj.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtMesaj.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMesaj.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMesaj.LineThickness = 3;
            this.txtMesaj.Location = new System.Drawing.Point(12, 487);
            this.txtMesaj.Margin = new System.Windows.Forms.Padding(4);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(600, 44);
            this.txtMesaj.TabIndex = 2;
            this.txtMesaj.Text = "Mesaj Yaz";
            this.txtMesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbChat
            // 
            this.lbChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(12, 126);
            this.lbChat.Name = "lbChat";
            this.lbChat.ScrollAlwaysVisible = true;
            this.lbChat.Size = new System.Drawing.Size(776, 353);
            this.lbChat.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Mesaj
            // 
            this.AcceptButton = this.btnGonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mesaj";
            this.Text = "Mesaj";
            this.Load += new System.EventHandler(this.Mesaj_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ListBox lbChat;
        private ns1.BunifuMaterialTextbox txtMesaj;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnFileTransfer;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclientIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtclientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtserverPort;
        private System.Windows.Forms.TextBox txtserverIP;
        private System.Windows.Forms.Button btnBaslat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}