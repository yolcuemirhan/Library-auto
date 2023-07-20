using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokKatmanliMimari.PL
{
    public partial class GorevliGecisForm : Form
    {
        public GorevliGecisForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GorevliGirisForm gorevliGiris = new GorevliGirisForm(); //Nesne oluşturuldu
            // Hide komutu ile aktif form kapatıldı
            this.Hide();
            //Show komutu ile oluşturulan nesneden yeni form açıldı
            gorevliGiris.Show();                               
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // Uygulama kapatıldı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciIslemForm ogrenci = new OgrenciIslemForm(); //Nesne oluşturuldu
            // Hide komutu ile aktif form kapatıldı
            this.Hide();                                     
            //Show komutu ile oluşturulan nesneden yeni form açıldı
            ogrenci.Show();                                 
        }

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            KitapIslemForm kitap = new KitapIslemForm();  // Nesne oluşturuldu
            this.Hide();  // Hide komutu ile aktif form kapatıldı
            kitap.Show();  //Show komutu ile oluşturulan nesneden yeni form açıldı
        }

        private void GorevliGecisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
