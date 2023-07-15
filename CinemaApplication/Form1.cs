using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApplication
{
    public partial class Form1 : Form
    {
        Sinema sinema;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelIslemlerGorunum(false);

        }


        public void PanelIslemlerGorunum(bool islem)
        {
            foreach (Control cnt in panel_Islemler.Controls)
            {
                cnt.Enabled = islem;
            }
        }
        private void button_salonAc_Click(object sender, EventArgs e)
        {
            string sinemaAd = textBox_sinemaAd.Text;
            int sinemaKisiSayisi;
            try
            {
                sinemaKisiSayisi = Convert.ToInt32(textBox_kisiSayisi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir kişi sayısı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            MessageBox.Show("Yeni salon oluşturuldu.", "Sinema Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBox_bilgilendirme.Text += "Salon oluşturuldu.\n";
            richTextBox_bilgilendirme.Text += $"Sinema ad: {sinemaAd}, kişi sayısı: {sinemaKisiSayisi}\n";
            sinema = new Sinema(sinemaAd, sinemaKisiSayisi);
            PanelIslemlerGorunum(true);
            SalonOlusturmayiEngelle(true);


        }
        public void SalonOlusturmayiEngelle(bool islem)
        {
            label_kisiSayisi.Enabled = !islem;
            label_sinemaAd.Enabled = !islem;
            textBox_kisiSayisi.Enabled = !islem;
            textBox_sinemaAd.Enabled = !islem;
            button_salonAc.Enabled = !islem;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult decision = MessageBox.Show("Çıkmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button_bakiye_Click(object sender, EventArgs e)
        {
            richTextBox_bilgilendirme.AppendText("\n>");
            richTextBox_bilgilendirme.Text += $"Bakiye: {sinema.BakiyeGoster()}";
            
        }

        private void button_satinAl_Click(object sender, EventArgs e)
        {
            richTextBox_bilgilendirme.AppendText("\n>");
            sinema.BiletSat(checkBox_ogrenciMi.Checked, richTextBox_bilgilendirme);
        }

        private void button_iptalEt_Click(object sender, EventArgs e)
        {
            richTextBox_bilgilendirme.AppendText("\n>");
            sinema.BiletIade(checkBox_ogrenciMi.Checked, richTextBox_bilgilendirme,this.sinema);
        }

        private void button_biletAlanlariGor_Click(object sender, EventArgs e)
        {
            richTextBox_bilgilendirme.AppendText("\n>");
            richTextBox_bilgilendirme.Text += $"Toplamda {sinema.TamBiletAdet+sinema.OgrenciBiletAdet} dolu koltuk; toplamda {sinema.KalanKoltukAdet} adet boş koltuk bulunmaktadır. ";
        }

        private void button_alinanOgrBilet_Click(object sender, EventArgs e)
        {
            richTextBox_bilgilendirme.AppendText("\n>");
            richTextBox_bilgilendirme.Text += $"Alınan öğrenci bilet adedi: {sinema.OgrenciBiletAdet}\n";
        }

        private void button_alinanYetiskinBilet_Click(object sender, EventArgs e)
        {
            richTextBox_bilgilendirme.AppendText("\n>");
            richTextBox_bilgilendirme.Text += $"Alınan tam bilet adedi: {sinema.TamBiletAdet} \n";
        }
    }
}
