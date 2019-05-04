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
        public int[] UrunAdetleri;
        public enum Hayvanlar
        {
             e_tavuk = 0,
            e_ordek = 1,
            e_keci = 2,
            e_inek = 3
        }

        public Ciftlik()
        {
            tavuk = new Tavuk();
            ordek = new Ordek();
            inek = new Inek();
            keci = new Keci();

            CiftlikZamani = 0;
            KasaParasi = 0;
            UrunAdetleri = new int[4];

            for (int i = 0; i < UrunAdetleri.Length; i++)
                UrunAdetleri[i] = 0;
        }

        public void TavukYemle()
        {
            if (tavuk.Yasam == true)
                tavuk.YemYe();
        }

        public void InekYemle()
        {
            if (inek.Yasam == true)
                inek.YemYe();
        }
        
        public void KeciYemle()
        {
            if (keci.Yasam == true)
                keci.YemYe();
        }

        public void OrdekYemle()
        {
            if (ordek.Yasam == true)
                ordek.YemYe();
        }

        public void UrunUret()
        {
            if(CiftlikZamani % 3 == 0)
                tavuk.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_tavuk]);
            if (CiftlikZamani % 5 == 0)
                ordek.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_ordek]);
            if (CiftlikZamani % 7 == 0)
                keci.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_keci]);
            if (CiftlikZamani % 8 == 0)
                inek.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_inek]);    
        }

        public void EnerjiHarca()
        {
            tavuk.EnerjiHarca();
            ordek.EnerjiHarca();
            inek.EnerjiHarca();
            keci.EnerjiHarca();
        }

        public void TavukYumurtasiSat()
        {
            KasaParasi += UrunAdetleri[0];
            UrunAdetleri[(int)Hayvanlar.e_tavuk] = 0;
        }

        public void OrdekYumurtasiSat()
        {
            KasaParasi += (3 * UrunAdetleri[1]);
            UrunAdetleri[(int)Hayvanlar.e_ordek] = 0;
        }

        public void KeciSutuSat()
        {
            KasaParasi += (8 * UrunAdetleri[2]);
            UrunAdetleri[(int)Hayvanlar.e_keci] = 0;
        }

        public void InekSutuSat()
        {
            KasaParasi += (5 * UrunAdetleri[3]);
            UrunAdetleri[(int)Hayvanlar.e_inek] = 0;
        }
    }
}
