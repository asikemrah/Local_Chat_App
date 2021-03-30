namespace Local_Chat_Uygulaması
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.chckShow = new ns1.BunifuCheckbox();
            this.txtSifre = new ns1.BunifuMaterialTextbox();
            this.txtEposta = new ns1.BunifuMaterialTextbox();
            this.txtSoyad = new ns1.BunifuMaterialTextbox();
            this.txtAd = new ns1.BunifuMaterialTextbox();
            this.btnGuncelle = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chckKadın = new ns1.BunifuCheckbox();
            this.chckErkek = new ns1.BunifuCheckbox();
            this.pbAyarlar = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.chckShow);
            this.bunifuGradientPanel1.Controls.Add(this.txtSifre);
            this.bunifuGradientPanel1.Controls.Add(this.txtEposta);
            this.bunifuGradientPanel1.Controls.Add(this.txtSoyad);
            this.bunifuGradientPanel1.Controls.Add(this.txtAd);
            this.bunifuGradientPanel1.Controls.Add(this.btnGuncelle);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.chckKadın);
            this.bunifuGradientPanel1.Controls.Add(this.chckErkek);
            this.bunifuGradientPanel1.Controls.Add(this.pbAyarlar);
            this.bunifuGradientPanel1.Controls.Add(this.btnMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(613, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Şifreyi Göster";
            // 
            // chckShow
            // 
            this.chckShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chckShow.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chckShow.Checked = true;
            this.chckShow.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chckShow.ForeColor = System.Drawing.Color.White;
            this.chckShow.Location = new System.Drawing.Point(587, 320);
            this.chckShow.Name = "chckShow";
            this.chckShow.Size = new System.Drawing.Size(20, 20);
            this.chckShow.TabIndex = 36;
            this.chckShow.OnChange += new System.EventHandler(this.chckShow_OnChange);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.Control;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.HintForeColor = System.Drawing.Color.Empty;
            this.txtSifre.HintText = "";
            this.txtSifre.isPassword = true;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(209, 309);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(370, 44);
            this.txtSifre.TabIndex = 35;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEposta
            // 
            this.txtEposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEposta.HintForeColor = System.Drawing.Color.Empty;
            this.txtEposta.HintText = "";
            this.txtEposta.isPassword = false;
            this.txtEposta.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtEposta.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEposta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEposta.LineThickness = 3;
            this.txtEposta.Location = new System.Drawing.Point(209, 257);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(370, 44);
            this.txtEposta.TabIndex = 34;
            this.txtEposta.Text = "E-posta";
            this.txtEposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEposta.Validating += new System.ComponentModel.CancelEventHandler(this.txtEposta_Validating);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyad.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoyad.HintText = "";
            this.txtSoyad.isPassword = false;
            this.txtSoyad.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSoyad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoyad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSoyad.LineThickness = 3;
            this.txtSoyad.Location = new System.Drawing.Point(209, 205);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(370, 44);
            this.txtSoyad.TabIndex = 33;
            this.txtSoyad.Text = "Soyadınız";
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAd.HintForeColor = System.Drawing.Color.Empty;
            this.txtAd.HintText = "";
            this.txtAd.isPassword = false;
            this.txtAd.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtAd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAd.LineThickness = 3;
            this.txtAd.Location = new System.Drawing.Point(209, 153);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(370, 44);
            this.txtAd.TabIndex = 32;
            this.txtAd.Text = "Adınız";
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ActiveBorderThickness = 1;
            this.btnGuncelle.ActiveCornerRadius = 20;
            this.btnGuncelle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuncelle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.ButtonText = "Güncelle";
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.IdleBorderThickness = 1;
            this.btnGuncelle.IdleCornerRadius = 20;
            this.btnGuncelle.IdleFillColor = System.Drawing.Color.White;
            this.btnGuncelle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(279, 393);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(238, 52);
            this.btnGuncelle.TabIndex = 31;
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kadın";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Erkek";
            // 
            // chckKadın
            // 
            this.chckKadın.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chckKadın.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chckKadın.Checked = true;
            this.chckKadın.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chckKadın.ForeColor = System.Drawing.Color.White;
            this.chckKadın.Location = new System.Drawing.Point(406, 360);
            this.chckKadın.Name = "chckKadın";
            this.chckKadın.Size = new System.Drawing.Size(20, 20);
            this.chckKadın.TabIndex = 28;
            this.chckKadın.OnChange += new System.EventHandler(this.chckKadın_OnChange);
            // 
            // chckErkek
            // 
            this.chckErkek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chckErkek.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chckErkek.Checked = true;
            this.chckErkek.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chckErkek.ForeColor = System.Drawing.Color.White;
            this.chckErkek.Location = new System.Drawing.Point(329, 360);
            this.chckErkek.Name = "chckErkek";
            this.chckErkek.Size = new System.Drawing.Size(20, 20);
            this.chckErkek.TabIndex = 27;
            this.chckErkek.OnChange += new System.EventHandler(this.chckErkek_OnChange);
            // 
            // pbAyarlar
            // 
            this.pbAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.pbAyarlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("pbAyarlar.Image")));
            this.pbAyarlar.Location = new System.Drawing.Point(332, 12);
            this.pbAyarlar.Name = "pbAyarlar";
            this.pbAyarlar.Size = new System.Drawing.Size(131, 129);
            this.pbAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAyarlar.TabIndex = 26;
            this.pbAyarlar.TabStop = false;
            this.pbAyarlar.Click += new System.EventHandler(this.pbAyarlar_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(728, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 38);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(765, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 38);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAyarlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuCheckbox chckShow;
        private ns1.BunifuMaterialTextbox txtSifre;
        private ns1.BunifuMaterialTextbox txtEposta;
        private ns1.BunifuMaterialTextbox txtSoyad;
        private ns1.BunifuMaterialTextbox txtAd;
        private ns1.BunifuThinButton2 btnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuCheckbox chckKadın;
        private ns1.BunifuCheckbox chckErkek;
        private System.Windows.Forms.PictureBox pbAyarlar;
    }
}