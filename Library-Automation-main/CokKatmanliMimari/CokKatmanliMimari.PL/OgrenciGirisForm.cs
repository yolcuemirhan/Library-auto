using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//gerekli katmanlar eklendi.
using Entity;  
using BL;     

namespace CokKatmanliMimari.PL
{
    public partial class OgrenciGirisForm : Form
    {
        public OgrenciGirisForm()
        {
            InitializeComponent();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Textlerin boş bırakılmaması sağlandı.
            if (txtOgrNo.Text != "" && txtOgrSifre.Text != "") 
            {
                //Entity katmanındaki verilere girilen değerler aktarıldı
                OgrenciVeri ogrenci = new OgrenciVeri()      
                {
                    OgrenciNo = txtOgrNo.Text,
                    OgrenciSifre = txtOgrSifre.Text

                };
                // Veritabanındaki tabloda girilen değerlere ait öğrenci var mı kontrol edildi
                if (OgrenciBL.ogrenciKontrol_BL(ogrenci) == true) 
                {
                    lblIdOgrenciGiris.Text = OgrenciBL.ogrenciIdSorgu(ogrenci).ToString(); //id ataması yapıldı
                    MessageBox.Show("Giriş Başarlı");
                    OgrenciForm ogr = new OgrenciForm();
                    ogr.lblIdOgrenciForm.Text = lblIdOgrenciGiris.Text;
                    this.Hide();//Hide komutu ile şuan bulunduğumuz form kapatıldı
                    ogr.Show(); //Show komutu ile oluşturulan nesne ile geçiş yapılacak form ekranı açıldı
                    
                    
                }
                else
                    MessageBox.Show("Hatalı giriş !");

            }

            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz!");
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Geçiş yapılacak formdan nesne oluşturuldu
            BaslangicForm baslangic = new BaslangicForm(); 
            this.Hide();// Hide komutu ile şuan bulunduğumuz form kapatıldı
            baslangic.Show(); //Show komutu ile oluşturulan nesne ile geçiş yapılacak form ekranı açıldı
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.CheckState == CheckState.Checked) // CheckBox seçili ise parolayı goster text e gizle yaz
            {
                txtOgrSifre.UseSystemPasswordChar = true;  // Parolayı göster 
                checkBox1.Text = "Gizle";                 // CheckBox textini gizle olarak değiştir
            }
            else if (checkBox1.CheckState == CheckState.Unchecked) // ChecBox seçili değil ise parolayı gizle ve text e göster yaz
            {
                txtOgrSifre.UseSystemPasswordChar = false;  // Parolayı gizle
                checkBox1.Text = "Göster";                 // CheckBox textini goster olarak değiştir
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // kapatma picture box ına basılınca uygulamayı kapatmasını sağladık.
            System.Windows.Forms.Application.Exit(); 
        }

        private void txtOgrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ogrenci NO textbox'ına harf girisini engelledik
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
