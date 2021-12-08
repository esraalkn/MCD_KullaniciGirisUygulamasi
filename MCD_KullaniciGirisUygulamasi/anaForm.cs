using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_KullaniciGirisUygulamasi
{
    public partial class anaForm : Form
    {
        public anaForm(Kullanici bulunanKullanici)
        {
            InitializeComponent();

            txtisim.Text = bulunanKullanici.isim;
            txtsoyisim.Text = bulunanKullanici.soyisim;
            txtkullaniciadi.Text = bulunanKullanici.kullaniciAdi;
            txtsifre.Text = bulunanKullanici.sifre;
            txtaciklama.Text = bulunanKullanici.aciklama;
            btnGuncelle.Tag = bulunanKullanici.id;


        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

        private void lblsoyisim_Click(object sender, EventArgs e)
        {

        }

        private void txtkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Buton btnGüncelleYakala  = (Button) sender;
            int id = (int)btnGuncelle.Tag;
            int index = SanalDatabase.KullaniciTablo.FindIndex(i => i.id == id);
            SanalDatabase.KullaniciTablo[index].isim = txtisim.Text;
            SanalDatabase.KullaniciTablo[index].soyisim = txtsoyisim.Text;
            SanalDatabase.KullaniciTablo[index].kullaniciAdi = txtkullaniciadi.Text;
            SanalDatabase.KullaniciTablo[index].sifre = txtsifre.Text;
            SanalDatabase.KullaniciTablo[index].aciklama = txtaciklama.Text;
            MessageBox.Show("Güncellenme tamamlandı");
        }
    }
}
