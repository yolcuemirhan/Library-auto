using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//kullanılacak katmanlar eklendi.
using BL;        
using Entity;   

namespace CokKatmanliMimari.PL
{
    public partial class OgrenciIslemForm : Form
    {
        public OgrenciIslemForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GorevliGecisForm gorevli = new GorevliGecisForm();  //  Gorevli gecisformundan nesne üretildi
            this.Hide();                                       // Bulunduğumuz form ekranı kapatıldı
            gorevli.Show();                                   // Gorevli nesnesini kullanarak gorevli gecis formu açıldı
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();  // Picturebox ' a tıklanınca uyguylamayı kapattık
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void OgrenciIslemForm_Load(object sender, EventArgs e)
        {
            ogrenciListe.DataSource = OgrenciBL.liste(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
            // Tablodaki görünümü iyileştirmek için genişliğini ayarladık ve isimlerini düzenledik.
            ogrenciListe.Columns[0].HeaderText = "Id";
            ogrenciListe.Columns[1].HeaderText = "Ad";
            ogrenciListe.Columns[2].HeaderText = "Soyad";
            ogrenciListe.Columns[3].HeaderText = "Okul NO";
            ogrenciListe.Columns[4].HeaderText = "Sifre";
            ogrenciListe.Columns[5].HeaderText = "Cinsiyet";
            ogrenciListe.Columns[6].HeaderText = "Ceza";

            // Form açıldığında guncelleme kısmındaki textboxların ve gunceleme için gerekli id nin boş kalmasını  sağladık.
            id = 0;
            txt_gAd.Text = "";
            txt_gSoyad.Text = "";
            txt_gNo.Text = "";
            txt_gSifre.Text = "";
            comboBox_gCinsiyet.Text = "";
        }

        private void ogrenciListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ekleme işlemi için textboxların dolu olup olmadığını kontrol ettik
            if (txtAd.Text!="" && txtSoyad.Text != "" && txtNo.Text != "" && txtSifre.Text != "" && comboBoxCinsiyet.Text != "")
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                OgrenciVeri ogrenci = new OgrenciVeri() 
                {
                    OgrenciAd = txtAd.Text,
                    OgrenciSoyad = txtSoyad.Text,
                    OgrenciNo = txtNo.Text,
                    OgrenciSifre = txtSifre.Text,
                    OgrenciCinsiyet = comboBoxCinsiyet.Text
                };
                // Öğrencinin kayıtlı olma durumu kontrol edildi
                if (OgrenciBL.ogrenciOkulNoKOntrol(ogrenci) == true)  
                {
                    //business katmanındaki ogrenciEkle fonksiyonuna verileri gönderdik
                    OgrenciBL.ogrenciEkle(ogrenci);  
                    MessageBox.Show("Eklendi");
                    // Ekleme işleminden sonra listenin güncel halini ekrana yansıttık
                    ogrenciListe.DataSource = OgrenciBL.liste(); 

                }

                else
                {
                    MessageBox.Show("Girilen okul numarasına ait farklı bir öğrenci mevcut, lütfen girilen okul numarasını değiştiriniz!");
                }

                //Ekleme işlemi bitince textboxları temizledik
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtNo.Text = "";
                txtSifre.Text = "";
                comboBoxCinsiyet.Text = null;

            }

            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Id nin girilmesini kontrol ettik
            if(txt_IdSil.Text !="")
            {
                //Entity katmanındaki OgrenciId değişkenine textboxtaki veriyi aktardık
                OgrenciVeri ogrenci = new OgrenciVeri()
                {
                    OgrenciId = int.Parse(txt_IdSil.Text)
                };

                //Girilen id ye ait ogrenci kontrol edildi
                if(OgrenciBL.ogrenciSorgu_BL(ogrenci) == true) 
                { 
                    // Business katmanındaki ogrenciSİL Fonksiyonuna silme işlemi için verileri gönderdik
                OgrenciBL.ogrenciSil(ogrenci); 
                MessageBox.Show("Silindi");
                    // Lİstenin güncel halini datagrid e yansıttık
                    ogrenciListe.DataSource = OgrenciBL.liste();
                    // Silme işleminden sonra textbox ı temizledik
                    txt_IdSil.Text = ""; 
                }

                else
                    MessageBox.Show("Geçersiz Id !");

            }
            else
                MessageBox.Show("Gerekli alanları doldurunuz!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Güncelleme işlemi için textboxların dolu olup olmadığını kontrol ettik
            if (txt_gAd.Text != "" && txt_gSoyad.Text != "" && txt_gNo.Text != "" && txt_gSifre.Text != "" && comboBox_gCinsiyet.Text != "")
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                OgrenciVeri ogrenci = new OgrenciVeri()
                {
                    OgrenciAd = txt_gAd.Text,
                    OgrenciSoyad = txt_gSoyad.Text,
                    OgrenciNo = txt_gNo.Text,
                    OgrenciSifre = txt_gSifre.Text,
                    OgrenciCinsiyet = comboBox_gCinsiyet.Text,
                    OgrenciId = id
                };

                // Girilen id ye ait ogrenci kontrol edildi
                if (OgrenciBL.ogrenciSorgu_BL(ogrenci) == true)
                {
                    if (OgrenciBL.ogrenciOkulNoKOntrol(ogrenci) == true || ilkNo == ogrenci.OgrenciNo.ToString())
                    {
                        OgrenciBL.ogrenciGuncelle(ogrenci);// Business katmanındaki ogrenciGuncelle Fonksiyonuna guncelleme işlemi için verileri gönderdik
                        MessageBox.Show("Guncellendi");
                        ogrenciListe.DataSource = OgrenciBL.liste();
                        // Lİstenin güncel halini datagrid e yansıttık
                        //Güncelleme işlemi bitince textboxları temizledik
                        txt_gAd.Text = "";
                        txt_gSoyad.Text = "";
                        txt_gNo.Text = "";
                        txt_gSifre.Text = "";
                        comboBox_gCinsiyet.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Güncellemek istediğiniz okul numarasına ait öğrenci mevcut, lütfen girilen okul numarasını değiştiriniz!");
                    }

                }

                else
                    MessageBox.Show("Lütfen listeden seçim yaptıktan sonra değerleri doldurunuz !");
            }

            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
            }

        }

        //id genel olarak kullanılacak.
        int id;
        string ilkNo;
        private void ogrenciListe_SelectionChanged(object sender, EventArgs e)
        {
            //Tablo üzerinde tıklanan satırın verilerini guncelleme alanındaki textboxlara yazdırdık
            id = int.Parse(ogrenciListe.CurrentRow.Cells[0].Value.ToString());
            txt_gAd.Text = ogrenciListe.CurrentRow.Cells[1].Value.ToString();
            txt_gSoyad.Text = ogrenciListe.CurrentRow.Cells[2].Value.ToString();
            txt_gNo.Text = ogrenciListe.CurrentRow.Cells[3].Value.ToString();
            txt_gSifre.Text = ogrenciListe.CurrentRow.Cells[4].Value.ToString();
            comboBox_gCinsiyet.Text = ogrenciListe.CurrentRow.Cells[5].Value.ToString();
            ilkNo = txt_gNo.Text;
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_IdSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            // harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_gNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
