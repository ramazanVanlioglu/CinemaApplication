namespace CinemaApplication
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
            this.textBox_sinemaAd = new System.Windows.Forms.TextBox();
            this.textBox_kisiSayisi = new System.Windows.Forms.TextBox();
            this.label_kisiSayisi = new System.Windows.Forms.Label();
            this.button_salonAc = new System.Windows.Forms.Button();
            this.label_sinemaAd = new System.Windows.Forms.Label();
            this.panel_Islemler = new System.Windows.Forms.Panel();
            this.checkBox_ogrenciMi = new System.Windows.Forms.CheckBox();
            this.button_bosKoltukSayisiGor = new System.Windows.Forms.Button();
            this.button_iptalEt = new System.Windows.Forms.Button();
            this.button_alinanYetiskinBilet = new System.Windows.Forms.Button();
            this.button_alinanOgrBilet = new System.Windows.Forms.Button();
            this.button_bakiye = new System.Windows.Forms.Button();
            this.button_satinAl = new System.Windows.Forms.Button();
            this.button_yeniSalon = new System.Windows.Forms.Button();
            this.richTextBox_bilgilendirme = new System.Windows.Forms.RichTextBox();
            this.panel_Islemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_sinemaAd
            // 
            this.textBox_sinemaAd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sinemaAd.Location = new System.Drawing.Point(151, 34);
            this.textBox_sinemaAd.Name = "textBox_sinemaAd";
            this.textBox_sinemaAd.Size = new System.Drawing.Size(135, 27);
            this.textBox_sinemaAd.TabIndex = 0;
            this.textBox_sinemaAd.Tag = "2";
            // 
            // textBox_kisiSayisi
            // 
            this.textBox_kisiSayisi.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kisiSayisi.Location = new System.Drawing.Point(151, 83);
            this.textBox_kisiSayisi.Name = "textBox_kisiSayisi";
            this.textBox_kisiSayisi.Size = new System.Drawing.Size(135, 27);
            this.textBox_kisiSayisi.TabIndex = 1;
            this.textBox_kisiSayisi.Tag = "2";
            // 
            // label_kisiSayisi
            // 
            this.label_kisiSayisi.AutoSize = true;
            this.label_kisiSayisi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kisiSayisi.Location = new System.Drawing.Point(1, 83);
            this.label_kisiSayisi.Name = "label_kisiSayisi";
            this.label_kisiSayisi.Size = new System.Drawing.Size(142, 23);
            this.label_kisiSayisi.TabIndex = 1;
            this.label_kisiSayisi.Tag = "2";
            this.label_kisiSayisi.Text = "Kişi Sayısı:";
            // 
            // button_salonAc
            // 
            this.button_salonAc.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_salonAc.Location = new System.Drawing.Point(306, 13);
            this.button_salonAc.Name = "button_salonAc";
            this.button_salonAc.Size = new System.Drawing.Size(193, 44);
            this.button_salonAc.TabIndex = 2;
            this.button_salonAc.Tag = "";
            this.button_salonAc.Text = "Salon Aç";
            this.button_salonAc.UseVisualStyleBackColor = true;
            this.button_salonAc.Click += new System.EventHandler(this.button_salonAc_Click);
            // 
            // label_sinemaAd
            // 
            this.label_sinemaAd.AutoSize = true;
            this.label_sinemaAd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sinemaAd.Location = new System.Drawing.Point(7, 37);
            this.label_sinemaAd.Name = "label_sinemaAd";
            this.label_sinemaAd.Size = new System.Drawing.Size(131, 23);
            this.label_sinemaAd.TabIndex = 1;
            this.label_sinemaAd.Tag = "2";
            this.label_sinemaAd.Text = "Sinema Adı:";
            // 
            // panel_Islemler
            // 
            this.panel_Islemler.Controls.Add(this.checkBox_ogrenciMi);
            this.panel_Islemler.Controls.Add(this.button_bosKoltukSayisiGor);
            this.panel_Islemler.Controls.Add(this.button_iptalEt);
            this.panel_Islemler.Controls.Add(this.button_alinanYetiskinBilet);
            this.panel_Islemler.Controls.Add(this.button_alinanOgrBilet);
            this.panel_Islemler.Controls.Add(this.button_bakiye);
            this.panel_Islemler.Controls.Add(this.button_satinAl);
            this.panel_Islemler.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_Islemler.Location = new System.Drawing.Point(5, 131);
            this.panel_Islemler.Name = "panel_Islemler";
            this.panel_Islemler.Size = new System.Drawing.Size(494, 234);
            this.panel_Islemler.TabIndex = 5;
            this.panel_Islemler.Tag = "0";
            // 
            // checkBox_ogrenciMi
            // 
            this.checkBox_ogrenciMi.AutoSize = true;
            this.checkBox_ogrenciMi.Location = new System.Drawing.Point(363, 28);
            this.checkBox_ogrenciMi.Name = "checkBox_ogrenciMi";
            this.checkBox_ogrenciMi.Size = new System.Drawing.Size(86, 22);
            this.checkBox_ogrenciMi.TabIndex = 6;
            this.checkBox_ogrenciMi.Text = "Öğrenci";
            this.checkBox_ogrenciMi.UseVisualStyleBackColor = true;
            // 
            // button_bosKoltukSayisiGor
            // 
            this.button_bosKoltukSayisiGor.Location = new System.Drawing.Point(241, 162);
            this.button_bosKoltukSayisiGor.Name = "button_bosKoltukSayisiGor";
            this.button_bosKoltukSayisiGor.Size = new System.Drawing.Size(116, 58);
            this.button_bosKoltukSayisiGor.TabIndex = 5;
            this.button_bosKoltukSayisiGor.Text = "Boş Koltuk Sayısını Gör";
            this.button_bosKoltukSayisiGor.UseVisualStyleBackColor = true;
            this.button_bosKoltukSayisiGor.Click += new System.EventHandler(this.button_biletAlanlariGor_Click);
            // 
            // button_iptalEt
            // 
            this.button_iptalEt.Location = new System.Drawing.Point(241, 92);
            this.button_iptalEt.Name = "button_iptalEt";
            this.button_iptalEt.Size = new System.Drawing.Size(116, 58);
            this.button_iptalEt.TabIndex = 4;
            this.button_iptalEt.Text = "İptal Et";
            this.button_iptalEt.UseVisualStyleBackColor = true;
            this.button_iptalEt.Click += new System.EventHandler(this.button_iptalEt_Click);
            // 
            // button_alinanYetiskinBilet
            // 
            this.button_alinanYetiskinBilet.Location = new System.Drawing.Point(53, 162);
            this.button_alinanYetiskinBilet.Name = "button_alinanYetiskinBilet";
            this.button_alinanYetiskinBilet.Size = new System.Drawing.Size(116, 58);
            this.button_alinanYetiskinBilet.TabIndex = 2;
            this.button_alinanYetiskinBilet.Text = "Alınan Tam Bilet Sayısı";
            this.button_alinanYetiskinBilet.UseVisualStyleBackColor = true;
            this.button_alinanYetiskinBilet.Click += new System.EventHandler(this.button_alinanYetiskinBilet_Click);
            // 
            // button_alinanOgrBilet
            // 
            this.button_alinanOgrBilet.Location = new System.Drawing.Point(53, 92);
            this.button_alinanOgrBilet.Name = "button_alinanOgrBilet";
            this.button_alinanOgrBilet.Size = new System.Drawing.Size(116, 64);
            this.button_alinanOgrBilet.TabIndex = 1;
            this.button_alinanOgrBilet.Text = "Alınan Öğrenci Bilet Sayısı";
            this.button_alinanOgrBilet.UseVisualStyleBackColor = true;
            this.button_alinanOgrBilet.Click += new System.EventHandler(this.button_alinanOgrBilet_Click);
            // 
            // button_bakiye
            // 
            this.button_bakiye.Location = new System.Drawing.Point(53, 28);
            this.button_bakiye.Name = "button_bakiye";
            this.button_bakiye.Size = new System.Drawing.Size(116, 58);
            this.button_bakiye.TabIndex = 0;
            this.button_bakiye.Tag = "1";
            this.button_bakiye.Text = "Bakiye Gör";
            this.button_bakiye.UseVisualStyleBackColor = true;
            this.button_bakiye.Click += new System.EventHandler(this.button_bakiye_Click);
            // 
            // button_satinAl
            // 
            this.button_satinAl.Location = new System.Drawing.Point(241, 28);
            this.button_satinAl.Name = "button_satinAl";
            this.button_satinAl.Size = new System.Drawing.Size(116, 58);
            this.button_satinAl.TabIndex = 3;
            this.button_satinAl.Text = "Bilet Sat";
            this.button_satinAl.UseVisualStyleBackColor = true;
            this.button_satinAl.Click += new System.EventHandler(this.button_satinAl_Click);
            // 
            // button_yeniSalon
            // 
            this.button_yeniSalon.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yeniSalon.Location = new System.Drawing.Point(306, 67);
            this.button_yeniSalon.Name = "button_yeniSalon";
            this.button_yeniSalon.Size = new System.Drawing.Size(193, 44);
            this.button_yeniSalon.TabIndex = 3;
            this.button_yeniSalon.Text = "Yeni Salon";
            this.button_yeniSalon.UseVisualStyleBackColor = true;
            // 
            // richTextBox_bilgilendirme
            // 
            this.richTextBox_bilgilendirme.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_bilgilendirme.ForeColor = System.Drawing.Color.SeaGreen;
            this.richTextBox_bilgilendirme.Location = new System.Drawing.Point(516, 12);
            this.richTextBox_bilgilendirme.Name = "richTextBox_bilgilendirme";
            this.richTextBox_bilgilendirme.ReadOnly = true;
            this.richTextBox_bilgilendirme.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_bilgilendirme.Size = new System.Drawing.Size(574, 353);
            this.richTextBox_bilgilendirme.TabIndex = 6;
            this.richTextBox_bilgilendirme.Text = "Bilgilendirme:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 377);
            this.Controls.Add(this.richTextBox_bilgilendirme);
            this.Controls.Add(this.button_yeniSalon);
            this.Controls.Add(this.panel_Islemler);
            this.Controls.Add(this.button_salonAc);
            this.Controls.Add(this.label_kisiSayisi);
            this.Controls.Add(this.label_sinemaAd);
            this.Controls.Add(this.textBox_kisiSayisi);
            this.Controls.Add(this.textBox_sinemaAd);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "2";
            this.Text = "Sinema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Islemler.ResumeLayout(false);
            this.panel_Islemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sinemaAd;
        private System.Windows.Forms.TextBox textBox_kisiSayisi;
        private System.Windows.Forms.Label label_kisiSayisi;
        private System.Windows.Forms.Button button_salonAc;
        private System.Windows.Forms.Label label_sinemaAd;
        private System.Windows.Forms.Panel panel_Islemler;
        private System.Windows.Forms.Button button_alinanYetiskinBilet;
        private System.Windows.Forms.Button button_alinanOgrBilet;
        private System.Windows.Forms.Button button_bakiye;
        private System.Windows.Forms.Button button_yeniSalon;
        private System.Windows.Forms.Button button_bosKoltukSayisiGor;
        private System.Windows.Forms.Button button_iptalEt;
        private System.Windows.Forms.Button button_satinAl;
        private System.Windows.Forms.CheckBox checkBox_ogrenciMi;
        private System.Windows.Forms.RichTextBox richTextBox_bilgilendirme;
    }
}

