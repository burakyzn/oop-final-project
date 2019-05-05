namespace FinalProject
{
    // hayvanların fonksiyonlarını buraya tanımladım. 
    // her hayvan bunlara sahip olmakla birlikte geliştirme yapılırken YemYe yada EnerjiHarca uzerine
    // coklu cagirmalarda bu interface uzerinden kullanabiliriz.
    interface IHayvan
    {
        void YemYe();
        void EnerjiHarca();
    }
}
