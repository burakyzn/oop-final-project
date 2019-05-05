namespace FinalProject
{
    class Ciftlik
    {
        // sinifin bu alaninda gerekli olan tanimlamalar yapildi
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
            e_inek = 3,
            TavukDeger = 1,
            OrdekDeger = 3,
            KeciDeger = 8,
            InekDeger = 5,
        }

        public Ciftlik()
        {
            // referanslara tavuk, ordek, inek ve keci nesneleri atandi.
            tavuk = new Tavuk();
            ordek = new Ordek();
            inek = new Inek();
            keci = new Keci();

            // ciftlik sinifi olusturuldugunda zaman, para ve urun adetleri sifir olarak basliyor.
            CiftlikZamani = 0;
            KasaParasi = 0;
            UrunAdetleri = new int[4];

            for (int i = 0; i < UrunAdetleri.Length; i++)
                UrunAdetleri[i] = 0;
        }

        public void TavukYemle()
        {
            // eger tavuk yasiyorsa yemek yenmesi soyleniyor.
            if (tavuk.Yasam == true)
                tavuk.YemYe();
        }

        public void InekYemle()
        {
            // eger inek yasiyorsa yemek yenmesi soyleniyor.
            if (inek.Yasam == true)
                inek.YemYe();
        }
        
        public void KeciYemle()
        {
            // eger keci yasiyorsa yemek yenmesi soyleniyor.
            if (keci.Yasam == true)
                keci.YemYe();
        }

        public void OrdekYemle()
        {
            // eger ordek yasiyorsa yemek yenmesi soyleniyor.
            if (ordek.Yasam == true)
                ordek.YemYe();
        }

        public void UrunUret()
        {
            // ciftlik zamanina gore uretim yaptiriliyor.
            if(CiftlikZamani % tavuk.UretimZamani == 0)
                tavuk.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_tavuk]);
            if (CiftlikZamani % ordek.UretimZamani == 0)
                ordek.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_ordek]);
            if (CiftlikZamani % keci.UretimZamani == 0)
                keci.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_keci]);
            if (CiftlikZamani % inek.UretimZamani == 0)
                inek.UrunUret(ref UrunAdetleri[(int)Hayvanlar.e_inek]);    
        }

        public void EnerjiHarca()
        {
            // EnerjiHarca fonksiyonu cagrildiginda tum hayvanlar icin enerji harcaniyor.
            tavuk.EnerjiHarca();
            ordek.EnerjiHarca();
            inek.EnerjiHarca();
            keci.EnerjiHarca();
        }

        public void TavukYumurtasiSat()
        {
            // tavuk yumurtalari satilmak istendiginde tavugun yumurta degeri urun adetiyle carpilir
            // ve kasaya o kadar tl eklenir.
            KasaParasi += ((int)Hayvanlar.TavukDeger * UrunAdetleri[(int)Hayvanlar.e_tavuk]);
            UrunAdetleri[(int)Hayvanlar.e_tavuk] = 0;
        }

        public void OrdekYumurtasiSat()
        {
            // ordek yumurtalari satilmak istendiginde ordegin yumurta degeri urun adetiyle carpilir
            // ve kasaya o kadar tl eklenir.
            KasaParasi += ((int)Hayvanlar.OrdekDeger * UrunAdetleri[(int)Hayvanlar.e_ordek]);
            UrunAdetleri[(int)Hayvanlar.e_ordek] = 0;
        }

        public void KeciSutuSat()
        {
            // keci sutu satilmak istendiginde kecinin sutunun degeri urun adetiyle carpilir
            // ve kasaya o kadar tl eklenir.
            KasaParasi += ((int)Hayvanlar.KeciDeger * UrunAdetleri[(int)Hayvanlar.e_keci]);
            UrunAdetleri[(int)Hayvanlar.e_keci] = 0;
        }

        public void InekSutuSat()
        {
            // inek sutu satilmak istendiginde kecinin sutunun degeri urun adetiyle carpilir
            // ve kasaya o kadar tl eklenir.
            KasaParasi += ((int)Hayvanlar.InekDeger * UrunAdetleri[(int)Hayvanlar.e_inek]);
            UrunAdetleri[(int)Hayvanlar.e_inek] = 0;
        }
    }
}
