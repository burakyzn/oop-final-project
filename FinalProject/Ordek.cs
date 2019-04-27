using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Ordek : Hayvanlar, IHayvan
    {
        public Ordek()
        {
            HarcananEnerji = 3;
        }

        public void YemYe()
        {
            Enerji=100;
        }

        public void UrunUret(ref int adet)
        {
            if (Yasam == true)
                adet++;
        }

        public void EnerjiHarca()
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
