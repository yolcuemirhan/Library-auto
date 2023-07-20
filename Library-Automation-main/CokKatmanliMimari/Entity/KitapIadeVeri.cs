using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    
    public class KitapIadeVeri
    {

        //Kitap iade işlem verileri diğer katmanlarda kullanabilmek amacı ile get set tanımlamarı yapıldı.

        int kitapKayitId,ogrenciId,kitapId;
        DateTime kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;
        float ogrenciCeza;

        
        public int KitapKayitId { get => kitapKayitId; set => kitapKayitId = value; }
        public int KitapId { get => kitapId; set => kitapId = value; }
        public int OgrenciId { get => ogrenciId; set => ogrenciId = value; }
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; } 
        public DateTime KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }
        public float OgrenciCeza { get => ogrenciCeza; set => ogrenciCeza = value; }
    }
}
