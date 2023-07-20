using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Veri tabanı bağlantısı için gerekli kütüphaneleri ekledik.
using System.Data.OleDb;  
using System.Data;      
using Entity; // Entity katmanını çağırdık.

namespace DAL
{
    public class GorevliDAL
    {
        //Görevlinin sistemde kayıtlı olup olmaması kontrol edildi.
        public static bool gorevliKontrol(GorevliVeri gorevli)
        {
            OleDbCommand command = new OleDbCommand("Select * from Gorevli where GorevliTc=@gorevTc and GorevliSifre=@gorevSifre", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@gorevTc", gorevli.gorevTc);
            command.Parameters.AddWithValue("@gorevSifre", gorevli.gorevSifre);

            OleDbDataReader okuma = command.ExecuteReader();
            bool sonuc = false;
            int sayac = 0;

            while (okuma.Read())
            {
                sayac++;
            }


            if (sayac > 0)
            {
                sonuc = true;
            }

            return sonuc;


        }
    }
}
