using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    
    public class GorevliVeri
    {


        //Görevli verilerini diğer katmanlarda kullanabilmek için get set tanımlamaları yapıldı
        int gorevliId;
        string gorevliAd, gorevliSoyad, gorevliTc, gorevliSifre;

        public int gorevId { get => gorevliId; set => gorevliId = value; }
        public string gorevAd { get => gorevliAd; set => gorevliAd = value; } //Örneğin burda görevlinin adını get ile alıp set ile tanımladık.
        public string gorevSoyad { get => gorevliSoyad; set => gorevliSoyad = value; }
        public string gorevTc { get => gorevliTc; set => gorevliTc = value; }
        public string gorevSifre { get => gorevliSifre; set => gorevliSifre = value; }
    }
}
