using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            tvkPrgBar.Value = 100;
            inekPrgBar.Value = 100;
            ordekPrgBar.Value = 100;
            KeciPrgBar.Value = 100;

        }

        private void TvkYemBtn_Click(object sender, EventArgs e)
        {
            YeniCiftligim.TavukYemle();
        }

        private void ÝnekYemBtn_Click(object sender, EventArgs e)
        {
            YeniCiftligim.ÝnekYemle();
        }

        private void KeciYemBtn_Click(object sender, EventArgs e)
        {
            YeniCiftligim.KeciYemle();
        }

        private void OrdekYemBtn_Click(object sender, EventArgs e)
        {
            YeniCiftligim.OrdekYemle();
        }

        private void AnlikOlaylar_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = YeniCiftligim.CiftlikZamani.ToString();
            lblKasa.Text = YeniCiftligim.KasaParasi.ToString();

            if(YeniCiftligim.inek.Yasam == true)
            {
                if (inekPrgBar.Value <= 0)
                {
                    YeniCiftligim.inek.Yasam = false;
                    lblInekYasam.Text = "ÖLÜ";

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
                if (tvkPrgBar.Value <= 0)
                {
                    YeniCiftligim.tavuk.Yasam = false;
                    lblTavukYasam.Text = "ÖLÜ";

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
                if (ordekPrgBar.Value <= 0)
                {
                    YeniCiftligim.ordek.Yasam = false;
                    lblOrdekYasam.Text = "ÖLÜ";

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
                if (KeciPrgBar.Value <= 0)
                {
                    YeniCiftligim.keci.Yasam = false;
                    lblKeciYasam.Text = "ÖLÜ";

                    SoundPlayer keciSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\keci.wav";
                    keciSes.SoundLocation = path;
                    keciSes.Play();
                }
                else
                    KeciPrgBar.Value = YeniCiftligim.keci.Enerji;
            }

            lblTavukUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_tavuk].ToString();
            lblOrdekUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_ordek].ToString();
            lblKeciUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_keci].ToString();
            lblInekUrun.Text = YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_inek].ToString();
        }

        private void BtnTavukSat_Click(object sender, EventArgs e)
        {
            if (YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_tavuk] != 0)
            {
                YeniCiftligim.TavukYumurtasiSat();
            }
        }

        private void BtnOrdekSat_Click(object sender, EventArgs e)
        {
            if(YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_ordek] != 0)
            {
                YeniCiftligim.OrdekYumurtasiSat();
            }
        }

        private void BtnInekSat_Click(object sender, EventArgs e)
        {
            if (YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_inek] != 0)
            {
                YeniCiftligim.ÝnekSutuSat();
            }
        }

        private void BtnKeciSat_Click(object sender, EventArgs e)
        {
            if (YeniCiftligim.UrunAdetleri[(int)Ciftlik.Hayvanlar.e_keci] != 0)
            {
                YeniCiftligim.KeciSutuSat();
            }
        }

        private void CiftlikZamani_Tick(object sender, EventArgs e)
        {   
            YeniCiftligim.CiftlikZamani++;
            YeniCiftligim.UrunUret();
            YeniCiftligim.EnerjiHarca();
        }
    }
}
