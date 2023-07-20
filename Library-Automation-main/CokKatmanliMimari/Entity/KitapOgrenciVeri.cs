using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    
    public class KitapOgrenciVeri
    {

        //Kitap ve ogrenci için kullanılan ortak verilerini diğer katmanlarda kullanabilmek için get set tanımlamaları yapıldı.

        int kitapId;
        string ogrenciAd, ogrenciSoyad, kitapAd, kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;

        
        public int KitapId { get => kitapId; set => kitapId = value; }
        public string OgrenciAd { get => ogrenciAd; set => ogrenciAd = value; }
        public string OgrenciSoyad { get => ogrenciSoyad; set => ogrenciSoyad = value; }
        public string KitapAd { get => kitapAd; set => kitapAd = value; }
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; } //Örneğin Öğrencinin kitabı alma tarihi get ve set ile tanımlandı.
        public string KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }

    }
}
