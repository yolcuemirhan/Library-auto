using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;      // DAL katmanını kullanmak için çağırdık.
using Entity;   // Entity katmanını kullanmak için çağırdık.

namespace BL
{
    public class GorevliBL
    {
        // Diğer classlardan erişim sağlayabilmek için Class'i public olarak tanımladık.

        //Girilen tc ve sifreye ait görevli veri tabanında kayıtlı olup olmadığını DAL katmanını kullanarak kontrol ettik.
        public static bool gorevliKontrol_BL(GorevliVeri gorevli)
        {
            if (gorevli.gorevTc != "" && gorevli.gorevSifre != "")
                return GorevliDAL.gorevliKontrol(gorevli);
            
            else
                return false;
        }
    }
}
