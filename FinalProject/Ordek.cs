namespace FinalProject
{
    class Ordek : Hayvanlar
    {
        // ordek nesnelerinin baslangic degerlerini belirdim.
        public Ordek()
        {
            UretimZamani = 5;
            HarcananEnerji = 3;
        }

        // YemYe methodu cagrildiginde ordegin sahip oldugu enerji 100 olacak.
        public override void YemYe()
        {
            Enerji=100;
        }

        // UrunUret methodu cagrildiginda ordek canli ise yumurta uretiyor.
        public void UrunUret(ref int adet)
        {
            if (Yasam == true)
                adet++;
        }

        // ordek her saniye enerji harciyor.
        public override void EnerjiHarca()
        {
            if (Yasam == true)
            {
                if (Enerji >= 3)
                    Enerji -= HarcananEnerji;
                else
                    Enerji -= Enerji;
            }
        }
    }
}
