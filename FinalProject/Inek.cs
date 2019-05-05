namespace FinalProject
{
    class Inek : Hayvanlar
    {
        // inek nesnelerinin baslangic degerlerini belirdim.
        public Inek()
        {
            UretimZamani = 8;
            HarcananEnerji = 6;
        }

        // YemYe methodu cagrildiginde inegin sahip oldugu enerji 100 olacak.
        public override void YemYe()
        {
            Enerji = 100;
        }

        // UrunUret methodu cagrildiginda tavuk inek ise sut uretiyor.
        public void UrunUret(ref int adet)
        {
            if (Yasam == true)
                adet++;
        }

        // inek her saniye enerji harciyor.
        public override void EnerjiHarca()
        {
            if (Yasam == true)
            {
                if (Enerji >= 6)
                    Enerji -= HarcananEnerji;
                else
                    Enerji -= Enerji;
            }
        }
    }
}
