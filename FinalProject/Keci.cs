namespace FinalProject
{
    class Keci : Hayvanlar
    {
        // keci nesnelerinin baslangic degerlerini belirdim.
        public Keci()
        {
            UretimZamani = 7;
            HarcananEnerji = 8;
        }

        // YemYe methodu cagrildiginde kecinin sahip oldugu enerji 100 olacak.
        public override void YemYe()
        {
            Enerji = 100;
        }

        // UrunUret methodu cagrildiginda keci canli ise sut uretiyor.
        public void UrunUret(ref int adet)
        {
            if (Yasam == true)
                adet++;
        }

        // keci her saniye enerji harciyor.
        public override void EnerjiHarca()
        {
            if (Yasam == true)
            {
                if (Enerji >= 8)
                    Enerji -= HarcananEnerji;
                else
                    Enerji -= Enerji;
            }
        }
    }
}
