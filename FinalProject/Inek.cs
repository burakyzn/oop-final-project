﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Inek : Hayvanlar
    {
        public Inek()
        {
            HarcananEnerji = 6;
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
