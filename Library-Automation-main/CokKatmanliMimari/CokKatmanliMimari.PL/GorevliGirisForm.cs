using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//kullancağımız katmanları ekledik.
using Entity;   
using BL;      

namespace CokKatmanliMimari.PL
{
    public partial class GorevliGirisForm : Form
    {
        public GorevliGirisForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaslangicForm baslangic = new BaslangicForm(); //Geçiş yapılacak formdan nesne oluşturuldu.
            this.Hide();                                  //Şuan ki form ekranı kapatıldı.
            baslangic.Show();                            //Geçiş yapılan form ekranı açıldı.
        }

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            if(txtGorevliTc.Text!="" && txtGorevliSifre.Text!="") // Textler boş olup olmadığı kontrol edildi
            {
                GorevliVeri gorevli = new GorevliVeri()  // Girilen veriler entity katmanındaki değişkenlere atandı
                {
                    gorevTc = txtGorevliTc.Text,
                    gorevSifre = txtGorevliSifre.Text
                };

                if(GorevliBL.gorevliKontrol_BL(gorevli)==true) //Girilen değerler veri tabanındaki tabloda mevcut ise işlem gerçekleşti
                    {
                        MessageBox.Show("Giriş başarılı");
                        GorevliGecisForm gorevliGecis = new GorevliGecisForm(); // Gorevli geçiş formundan nesne üretildi
                        this.Hide();                                           // Bulunduğumuz fonksiyon kapatıldı
                        gorevliGecis.Show();                                  // Oluşturulan nesnenin formu açıldı
                    }

                else
                {
                    MessageBox.Show("Hatalı giriş");
                }

            }

            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) // seçili ise parolayı goster 
            {
                txtGorevliSifre.UseSystemPasswordChar = true;
                // text e gizle yazdır
                checkBox1.Text = "Gizle";
            }
            else if(checkBox1.CheckState==CheckState.Unchecked) //CheckBox seçili değil ise parolayı gizle 
            {
                txtGorevliSifre.UseSystemPasswordChar = false;
                // text e göster yazdır
                checkBox1.Text = "Göster";
            }
        }

        private void GorevliGirisForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // Picturebox' a tıklayınca uygulamayı kapattırdık
        }

        private void txtGorevliTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGorevliTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TC kimlik textbox'ına harf girisini engelledik
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
