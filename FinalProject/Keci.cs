﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Keci : Hayvanlar, IHayvan
    {
        public Keci()
        {
            HarcananEnerji = 8;
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
                if (Enerji >= 8)
                    Enerji -= HarcananEnerji;
                else
                    Enerji -= Enerji;
            }
        }
    }
}
