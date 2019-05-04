namespace FinalProject
{
    class Tavuk : Hayvanlar
    {
        public Tavuk()
        {
            HarcananEnerji = 2;
        }

        public override void YemYe()
        {
            Enerji = 100;
        }

        public void UrunUret(ref int adet)
        {
            if (Yasam == true)
                adet++;
        }

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
