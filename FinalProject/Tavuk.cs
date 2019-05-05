
namespace FinalProject
{
    class Tavuk : Hayvanlar
    {
        // tavuk nesnelerinin baslangic degerlerini belirdim.
        public Tavuk()
        {
            HarcananEnerji = 2;
            UretimZamani = 3;
        }

        // YemYe methodu cagrildiginde tavugun sahip oldugu enerji 100 olacak.
        public override void YemYe()
        {
            Enerji = 100;
        }

        // UrunUret methodu cagrildiginda tavuk canli ise yumurta uretiyor.
        public void UrunUret(ref int adet)
        {
            if (Yasam == true)
                adet++;
        }

        // tavuk her saniye enerji harciyor.
        public override void EnerjiHarca()
        {
            if(Yasam == true)
            {
                if (Enerji >= 2)
                    Enerji -= HarcananEnerji;
                else
                    Enerji -= Enerji;
            }
                
        }
    }
}
