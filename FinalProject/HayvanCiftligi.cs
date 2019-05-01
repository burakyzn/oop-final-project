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
        Ciftlik yeniCiftligim;
        public HayvanCiftligi()
        {
            InitializeComponent();
        }

        private void HayvanCiftligi_Load(object sender, EventArgs e)
        {
            yeniCiftligim = new Ciftlik();

            tvkPrgBar.Value = 100;
            inekPrgBar.Value = 100;
            ordekPrgBar.Value = 100;
            KeciPrgBar.Value = 100;

        }

        private void tvkYemBtn_Click(object sender, EventArgs e)
        {
            yeniCiftligim.tavukYemle();
        }

        private void inekYemBtn_Click(object sender, EventArgs e)
        {
            yeniCiftligim.inekYemle();
        }

        private void keciYemBtn_Click(object sender, EventArgs e)
        {
            yeniCiftligim.keciYemle();
        }

        private void ordekYemBtn_Click(object sender, EventArgs e)
        {
            yeniCiftligim.ordekYemle();
        }

        private void anlikOlaylar_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = yeniCiftligim.CiftlikZamani.ToString();
            lblKasa.Text = yeniCiftligim.KasaParasi.ToString();

            if(yeniCiftligim.inek.Yasam == true)
            {
                if (inekPrgBar.Value <= 0)
                {
                    yeniCiftligim.inek.Yasam = false;
                    lblInekYasam.Text = "ÖLÜ";

                    SoundPlayer inekSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\inek.wav";
                    inekSes.SoundLocation = path;
                    inekSes.Play();
                }
                else
                    inekPrgBar.Value = yeniCiftligim.inek.Enerji;
                
            }

            if(yeniCiftligim.tavuk.Yasam == true)
            {
                if (tvkPrgBar.Value <= 0)
                {
                    yeniCiftligim.tavuk.Yasam = false;
                    lblTavukYasam.Text = "ÖLÜ";

                    SoundPlayer tavukSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\tavuk.wav";
                    tavukSes.SoundLocation = path;
                    tavukSes.Play();
                }
                else
                    tvkPrgBar.Value = yeniCiftligim.tavuk.Enerji;

            }

            if (yeniCiftligim.ordek.Yasam == true)
            {
                if (ordekPrgBar.Value <= 0)
                {
                    yeniCiftligim.ordek.Yasam = false;
                    lblOrdekYasam.Text = "ÖLÜ";

                    SoundPlayer ordekSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\ordek.wav";
                    ordekSes.SoundLocation = path;
                    ordekSes.Play();
                }
                else
                    ordekPrgBar.Value = yeniCiftligim.ordek.Enerji;

            }

            if (yeniCiftligim.keci.Yasam == true)
            {
                if (KeciPrgBar.Value <= 0)
                {
                    yeniCiftligim.keci.Yasam = false;
                    lblKeciYasam.Text = "ÖLÜ";

                    SoundPlayer keciSes = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\keci.wav";
                    keciSes.SoundLocation = path;
                    keciSes.Play();
                }
                else
                    KeciPrgBar.Value = yeniCiftligim.keci.Enerji;
            }

            lblTavukUrun.Text = yeniCiftligim.urunAdetleri[0].ToString();
            lblOrdekUrun.Text = yeniCiftligim.urunAdetleri[1].ToString();
            lblKeciUrun.Text = yeniCiftligim.urunAdetleri[2].ToString();
            lblInekUrun.Text = yeniCiftligim.urunAdetleri[3].ToString();
        }

        private void btnTavukSat_Click(object sender, EventArgs e)
        {
            if (lblTavukUrun.Text != "0")
            {
                yeniCiftligim.tavukYumurtasiSat();
            }
        }

        private void btnOrdekSat_Click(object sender, EventArgs e)
        {
            if(lblOrdekUrun.Text != "0")
            {
                yeniCiftligim.ordekYumurtasiSat();
            }
        }

        private void btnInekSat_Click(object sender, EventArgs e)
        {
            if (lblInekUrun.Text != "0")
            {
                yeniCiftligim.inekSutuSat();
            }
        }

        private void btnKeciSat_Click(object sender, EventArgs e)
        {
            if (lblKeciUrun.Text != "0")
            {
                yeniCiftligim.KeciSutuSat();
            }
        }

        private void ciftlikZamani_Tick(object sender, EventArgs e)
        {   
            yeniCiftligim.CiftlikZamani++;
            yeniCiftligim.urunUret();
            yeniCiftligim.enerjiHarca();
        }
    }
}
