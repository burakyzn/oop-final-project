using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Ciftlik
    {
        public Tavuk tavuk;
        public Ordek ordek;
        public Inek inek;
        public Keci keci;
        public int CiftlikZamani { get; set; }
        public int KasaParasi { get; set;}
        public int[] urunAdetleri;

        public Ciftlik()
        {
            tavuk = new Tavuk();
            ordek = new Ordek();
            inek = new Inek();
            keci = new Keci();

            CiftlikZamani = 0;
            KasaParasi = 0;
            urunAdetleri = new int[4];

            for (int i = 0; i < urunAdetleri.Length; i++)
                urunAdetleri[i] = 0;
        }

        public void tavukYemle()
        {
            if (tavuk.Yasam == true)
                tavuk.YemYe();
        }

        public void inekYemle()
        {
            if (inek.Yasam == true)
                inek.YemYe();
        }
        
        public void keciYemle()
        {
            if (keci.Yasam == true)
                keci.YemYe();
        }

        public void ordekYemle()
        {
            if (ordek.Yasam == true)
                ordek.YemYe();
        }

        public void urunUret()
        {
            if(CiftlikZamani % 3 == 0)
                tavuk.UrunUret(ref urunAdetleri[0]);
            if (CiftlikZamani % 5 == 0)
                ordek.UrunUret(ref urunAdetleri[1]);
            if (CiftlikZamani % 7 == 0)
                keci.UrunUret(ref urunAdetleri[2]);
            if (CiftlikZamani % 8 == 0)
                inek.UrunUret(ref urunAdetleri[3]);    
        }

        public void enerjiHarca()
        {
            tavuk.EnerjiHarca();
            ordek.EnerjiHarca();
            inek.EnerjiHarca();
            keci.EnerjiHarca();
        }

        public void tavukYumurtasiSat()
        {
            urunAdetleri[0]--;
            KasaParasi++;
        }

        public void ordekYumurtasiSat()
        {
            urunAdetleri[1]--;
            KasaParasi += 3;
        }

        public void inekSutuSat()
        {
            urunAdetleri[3]--;
            KasaParasi += 5;
        }

        internal void KeciSutuSat()
        {
            urunAdetleri[2]--;
            KasaParasi += 8;
        }
    }
}
