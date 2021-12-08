using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KullaniciGirisUygulamasi
{
   public class SanalDatabase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();

        static SanalDatabase()
        {
            KullaniciTablo.Add(new Kullanici()
            {
                id = 1,
                isim = "Esra",
                soyisim = "Alkan",
                kullaniciAdi = "es.alknn",
                sifre = "1",
                aciklama = "Esra Alkan kullanıcı profil bilgisi"

            });


            KullaniciTablo.Add(new Kullanici()
            {
                id = 2,
                isim = "Esin",
                soyisim = "Alkan",
                kullaniciAdi = "esnn.alknn",
                sifre = "2",
                aciklama = "Esin Alkan kullanıcı profil bilgisi"

            });
        }
    }
}
