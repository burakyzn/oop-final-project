using System;
using System.Windows.Forms;
using System.Media;

namespace FinalProject
{
    public partial class HayvanCiftligi : Form
    {
        Ciftlik YeniCiftligim;
        public HayvanCiftligi()
        {
            InitializeComponent();
        }

        private void HayvanCiftligi_Load(object sender, EventArgs e)
        {
            YeniCiftligim = new Ciftlik();

            // tum progressbarlarin degerlerini ait olduklari nesnelerin enerjilerine esitledim.
            tvkPrgBar.Value = YeniCiftligim.tavuk.Enerji;
            inekPrgBar.Value = YeniCiftligim.inek.Enerji;
            ordekPrgBar.Value = YeniCiftligim.ordek.Enerji;
            KeciPrgBar.Value = YeniCiftligim.keci.Enerji;

        }

        private void TvkYemBtn_Click(object sender, EventArgs e)
        {
            // tavuk yem butonuna basildiginde ciftlik sifina ait olan yeni ciftligim nesnesinin 
            // TavukYemle methodu cagrilacaktir.
            YeniCiftligim.TavukYemle();
        }

        private void InekYemBtn_Click(object sender, EventArgs e)
        {   
            // inek yem butonuna basildiginde ciftlik sifina ait olan yeni ciftligim nesnesinin 
            // InekYemle methodu cagrilacaktir.
            YeniCiftligim.InekYemle();
        }

        private void KeciYemBtn_Click(object sender, EventArgs e)
        {
            // keci yem butonuna basildiginde ciftlik sifina ait olan yeni ciftligim nesnesinin 
            // KeciYemle methodu cagrilacaktir.
            YeniCiftligim.KeciYemle();
        }

        private void OrdekYemBtn_Click(object sender, EventArgs e)
        {
            // ordek yem butonuna basildiginde ciftlik sifina ait olan yeni ciftligim nesnesinin 
            // OrdekYemle methodu cagrilacaktir.
            YeniCiftligim.OrdekYemle();
        }

        private void AnlikOlaylar_Tick(object sender, EventArgs e)
        {
            // her an zaman ciftlikte donen zamana esit, kasa ciftlikte tutulan paraya esit olacaktir.
            lblZaman.Text = YeniCiftligim.CiftlikZamani.ToString() + " SN";
            lblKasa.Text = YeniCiftligim.KasaParasi.ToString() + " TL";

            // bu 4 blokta olen hayvan var mý kontrol yapýlýyor.
            if(YeniCiftligim.inek.Yasam == true)
            {
                // eger inegin enerjisi 0'in altina dustuyse inek olmustur.
                if (YeniCiftligim.inek.Enerji <= 0)
                {
                    YeniCiftligim.inek.Yasam = false;
                    inekPrgBar.Value = 0;
                    lblInekYasam.Text = "ÖLÜ";

                    // inek olum ses efekti
                    SoundPlayer inekSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\inek.wav";
                    inekSes.SoundLocation = path;
                    inekSes.Play();
                }
                else
                    inekPrgBar.Value = YeniCiftligim.inek.Enerji;
            }

            if(YeniCiftligim.tavuk.Yasam == true)
            {
                // eger tavugun enerjisi 0'in altina dustuyse tavuk olmustur.
                if (YeniCiftligim.tavuk.Enerji <= 0)
                {
                    YeniCiftligim.tavuk.Yasam = false;
                    tvkPrgBar.Value = 0;
                    lblTavukYasam.Text = "ÖLÜ";

                    // tavuk olum ses efekti
                    SoundPlayer tavukSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\tavuk.wav";
                    tavukSes.SoundLocation = path;
                    tavukSes.Play();
                }
                else
                    tvkPrgBar.Value = YeniCiftligim.tavuk.Enerji;

            }

            if (YeniCiftligim.ordek.Yasam == true)
            {
                // eger ordek enerjisi 0'in altina dustuyse ordek olmustur.
                if (YeniCiftligim.ordek.Enerji <= 0)
                {
                    YeniCiftligim.ordek.Yasam = false;
                    ordekPrgBar.Value = 0;
                    lblOrdekYasam.Text = "ÖLÜ";

                    // ordek olum ses efekti
                    SoundPlayer ordekSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\ordek.wav";
                    ordekSes.SoundLocation = path;
                    ordekSes.Play();
                }
                else
                    ordekPrgBar.Value = YeniCiftligim.ordek.Enerji;

            }

            if (YeniCiftligim.keci.Yasam == true)
            {
                // eger keci enerjisi 0'in altina dustuyse keci olmustur.
                if (YeniCiftligim.keci.Enerji <= 0)
                {
                    YeniCiftligim.keci.Yasam = false;
                    KeciPrgBar.Value = 0;
                    lblKeciYasam.Text = "ÖLÜ";

                    // keci olum ses efekti
                    SoundPlayer keciSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\keci.wav";
                    keciSes.SoundLocation = path;
                    keciSes.Play();
                }
                else
                    KeciPrgBar.Value = YeniCiftligim.keci.Enerji;
            }

            // burada ciftlikteki urun adetlerini cekip ekranda gosteriyorum.
            lblTavukUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_tavuk].ToString() + " Adet";
            lblOrdekUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_ordek].ToString() + " Adet";
            lblKeciUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_keci].ToString() + " Litre";
            lblInekUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_inek].ToString() + " Litre";
        }

        private void BtnTavukSat_Click(object sender, EventArgs e)
        {
            // eger ciftlikte urun varsa satmasi icin method cagriliyor.
            if (YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_tavuk] != 0)
            {
                YeniCiftligim.TavukYumurtasiSat();
            }
        }

        private void BtnOrdekSat_Click(object sender, EventArgs e)
        {
            // eger ciftlikte urun varsa satmasi icin method cagriliyor.
            if (YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_ordek] != 0)
            {
                YeniCiftligim.OrdekYumurtasiSat();
            }
        }

        private void BtnInekSat_Click(object sender, EventArgs e)
        {
            // eger ciftlikte urun varsa satmasi icin method cagriliyor.
            if (YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_inek] != 0)
            {
                YeniCiftligim.InekSutuSat();
            }
        }

        private void BtnKeciSat_Click(object sender, EventArgs e)
        {
            // eger ciftlikte urun varsa satmasi icin method cagriliyor.
            if (YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_keci] != 0)
            {
                YeniCiftligim.KeciSutuSat();
            }
        }

        private void CiftlikZamani_Tick(object sender, EventArgs e)
        {   
            // her saniye ciftlikte gecen zaman 1 saniye arttiriliyor.
            YeniCiftligim.CiftlikZamani++;
            // her saniye UrunUret ve EnerjiHarca fonksiyonlari cagriliyor.
            YeniCiftligim.UrunUret();
            YeniCiftligim.EnerjiHarca();
        }
    }
}
