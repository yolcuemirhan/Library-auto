using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;      // DAL  katmanını kullanmak için çağırdık.
using Entity;  //   Entity  katmanını kullanmak için çağırdık.

namespace BL
{
    public class OgrenciBL
    {
        public static bool ogrenciKontrol_BL(OgrenciVeri ogrenci)
        {
            // Verilerin boş olup olmadığı kontrol ediliyor.
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") 
            {
                // Veritabanından girilen değerlere ait öğrenci kontrol edildi
                return OgrenciDAL.ogrenciKontrol(ogrenci); 
            }

            else
                //gelen veri boş ise false döndürdü
                return true;
        }

        public static bool ogrenciOkulNoKOntrol(OgrenciVeri ogrenci)
        {
            // Gelen verilerin boş olmadığı kontrol edildi
            if (ogrenci.OgrenciNo != "") 
            {
                // Veritabanından girilen değerlere ait öğrenci kontrol edildi
                return OgrenciDAL.OgrenciOkulNoKontrol(ogrenci);
            }

            else
                //Eğer gelen veri boş ise false döndürdü
                return false;
        }

        public static int ogrenciIdSorgu(OgrenciVeri ogrenci)
        {
            // Gelen verilerin boş olmadığı kontrol edildi
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") 
            {
                // Veritabanından girilen değerlere ait öğrenci kontrol edildi
                return OgrenciDAL.ogrenciIdSorgu(ogrenci); 
            }

            else
                //Eğer gelen veri boş ise false döndürdü
                return -1;
        }

        public static OgrenciVeri ogrenciIdBilgi(OgrenciVeri ogrenci)
        {
            // Gelen verilerin boş olmadığı kontrol edildi
            if (ogrenci.OgrenciId != 0) 
            {
                // Veritabanından girilen değerlere ait öğrenci kontrol edildi
                return OgrenciDAL.ogrenciIdBilgi(ogrenci); 
            }

            else
                //Eğer gelen veri boş ise NULL döndürdü
                return null;
        }

        public static bool ogrenciSorgu_BL(OgrenciVeri ogrenci)
        {
            // Gelen verilerin boş olmadığı kontrol edildi
            if (ogrenci.OgrenciId != 0) 
            {
                // Veritabanından girilen değerlere ait öğrenci kontrol edildi
                return OgrenciDAL.ogrenciSorgu(ogrenci);
            }

            else
                //Eğer gelen veri boş ise false döndürdü
                return false;
        }


        //Girilen öğrenci bilgileri DAL katmanı kullanılarak veritabanına eklendi
        public static int ogrenciEkle(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciAd != "" && ogrenci.OgrenciSoyad != "" && ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "" && ogrenci.OgrenciCinsiyet != "")
            {

                return OgrenciDAL.ogrenciEkle(ogrenci);
            }

            else
                return -1;
        }


        //Girilen id 'ye  ait öğrenci DAL katmanı kullanılarak veri tabanından silindi
        public static int ogrenciSil(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciId != 0)
            {

                return OgrenciDAL.ogrenciSil(ogrenci);
            }

            else
                return -1;
        }

        //Girilen id 'ye  ait öğrenci DAL katmanı kullanılarak veri tabanındaki verileri güncellendi
        public static int ogrenciGuncelle(OgrenciVeri ogrenci)
        {
            if (ogrenci.OgrenciAd != "" && ogrenci.OgrenciSoyad != "" && ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "" && ogrenci.OgrenciCinsiyet != "" && ogrenci.OgrenciId != 0)
            {

                return OgrenciDAL.ogrenciGuncelle(ogrenci);
            }

            else
                return -1;
        }


        //Veri tabanındaki tüm öğrenci bilgileri DAL katmanı kullanılarak listeye aktarıldı
        public static List<OgrenciVeri> liste()
        {
           
            return OgrenciDAL.liste();
        }

        




    }
}
