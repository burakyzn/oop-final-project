using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Hayvanlar : IHayvan
    {
        public int Enerji { get; set; }
        public int HarcananEnerji { get; set; }
        public bool Yasam { get; set; }

        public Hayvanlar()
        {
            Enerji = 100;
            Yasam = true;
        }

        abstract public void YemYe();

        abstract public void EnerjiHarca();
    }
}
