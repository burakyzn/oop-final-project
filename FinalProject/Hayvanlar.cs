namespace FinalProject
{
    // hayvanlarin ortak ozelliklerini bu sinifta topladim. Hayvan diye bir nesne olusturulmayacagi icin 
    // bu sınıf abstract olarak tanımlandı. Görevi sadece kalıtım alıcak hayvanlara cati olmaktir.
    abstract class Hayvanlar : IHayvan
    {
        public int Enerji { get; set; }
        public int HarcananEnerji { get; set; }
        public bool Yasam { get; set; }
        public int UretimZamani { get; set; }

        // hayvanlar sinifindan kalitim almis tum siniflardan olusmus nesneler icin tanimlandi.
        public Hayvanlar()
        {
            Enerji = 100;
            Yasam = true;
        }

        abstract public void YemYe();

        abstract public void EnerjiHarca();
    }
}
