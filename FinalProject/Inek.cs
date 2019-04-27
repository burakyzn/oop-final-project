using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Inek : Hayvanlar, IHayvan
    {
        public Inek()
        {
            HarcananEnerji = 6;
        }

        public void YemYe()
        {
            Enerji = 100;
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
                if (Enerji >= 6)
                    Enerji -= HarcananEnerji;
                else
                    Enerji -= Enerji;
            }
        }
    }
}
