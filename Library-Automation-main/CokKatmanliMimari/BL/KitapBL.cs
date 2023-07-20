﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;      // DAL katmanını kullanmak için çağırdık.
using Entity;  //   Entity katmanını kullanmak için çağırdık.

namespace BL
{
    public class KitapBL
    {
        //Girilen KitapId ye ait kitap veri tabanında kayıtlı mı diye DAL katmanı kullanılarak kontrol edildi
        public static bool kitapSorgu_BL(KitapVeri kitap)
        {
            // Gelen verilerin boş olmadığı kontrol edildi
            if (kitap.KitapId != 0)
            {
                // Veritabanından girilen değerlere ait kitap kontrol edildi
                return KitapDAL.kitapSorgu(kitap); 
            }

            else
                //Eğer gelen veri boş ise false döndürdü
                return false;
        }


        //Kitap ekleme işlemi DAL katmanı kullanılarak gerçekleştirildi
        public static int kitapEkle(KitapVeri kitap)
        {
            if (kitap.KitapAd != "" && kitap.KitapTuru != "" && kitap.KitapSayfa != "" && kitap.KitapYazar != "")
            {

                return KitapDAL.kitapEkle(kitap);
            }

            else
                return -1;
        }

        //Kİtap bilgilerinin olduğu liste DAL katmanı kullanılarak aktarıldı
        public static List<KitapVeri> kitapListe()
        {

            return KitapDAL.kitapListe();
        }


        // Id ' ye ait kitap  DAL katmanı kullanılara silindi
        public static int kitapSil(KitapVeri kitap)
        {
            if (kitap.KitapId != 0)
            {

                return KitapDAL.kitapSil(kitap);
            }

            else
                return -1;
        }


        // Id' ye kitap DAL katmanı kullanılarak güncellendi
        public static int kitapGuncelle(KitapVeri kitap)
        {
            if (kitap.KitapId !=0 && kitap.KitapAd!= "" && kitap.KitapTuru != "" && kitap.KitapSayfa!= "" && kitap.KitapYazar != "" )
            {

                return KitapDAL.kitapGuncelle(kitap);
            }

            else
                return -1;
        }

        // DAL katmanı kullanılarak Kitap id ile kitap bilgileri çekildi
        public static KitapVeri kitapIdBilgi(KitapVeri kitap)
        {
            // Gelen verilerin boş olmadığı kontrol edildi
            if (kitap.KitapId != 0) 
            {
                // Veritabanından girilen değerlere ait öğrenci kontrol edildi
                return KitapDAL.kitapIdBilgi(kitap); 
            }

            else
                //Eğer gelen veri boş ise false döndürdü
                return null;
        }
    }
}
