using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        Tavuk tavuk;
        Ordek ordek;
        Inek inek;
        Keci keci;
        int ciftlikZamani;
        int kasaParasi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tvkPrgBar.Value = 100;
            inekPrgBar.Value = 100;
            ordekPrgBar.Value = 100;
            KeciPrgBar.Value = 100;

            tavuk = new Tavuk();
            ordek = new Ordek();
            inek = new Inek();
            keci = new Keci();

            ciftlikZamani = 0;
            kasaParasi = 0;

        }

        private void tvkYemBtn_Click(object sender, EventArgs e)
        {
            if(tavuk.Yasam == true)
                tavuk.YemYe();
        }

        private void inekYemBtn_Click(object sender, EventArgs e)
        {
            if(inek.Yasam == true)
                inek.YemYe();
        }

        private void keciYemBtn_Click(object sender, EventArgs e)
        {
            if(keci.Yasam == true)
                keci.YemYe();
        }

        private void ordekYemBtn_Click(object sender, EventArgs e)
        {
            if(ordek.Yasam == true)
                ordek.YemYe();
        }

        private void tvkTmr_Tick(object sender, EventArgs e)
        {
            tavuk.UrunUret();
        }

        private void inkTmr_Tick(object sender, EventArgs e)
        {
            inek.UrunUret();
        }

        private void ordkTmr_Tick(object sender, EventArgs e)
        {
            ordek.UrunUret();
        }

        private void keciTmr_Tick(object sender, EventArgs e)
        {
            keci.UrunUret();
        }

        private void ciftlikZaman_Tick(object sender, EventArgs e)
        {
            ciftlikZamani++;

            tavuk.EnerjiHarca();
            ordek.EnerjiHarca();
            inek.EnerjiHarca();
            keci.EnerjiHarca();
        } 

        private void anlikOlaylar_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = ciftlikZamani.ToString();
            lblKasa.Text = kasaParasi.ToString();

            if(inek.Yasam == true)
            {
                if (inekPrgBar.Value <= 0)
                {
                    inek.Yasam = false;
                    lblInekYasam.Text = "ÖLÜ";
                }
                else
                {
                    inekPrgBar.Value = inek.Enerji;

                }
            }

            if(tavuk.Yasam == true)
            {
                if (tvkPrgBar.Value <= 0)
                {
                    tavuk.Yasam = false;
                    lblTavukYasam.Text = "ÖLÜ";
                }
                else
                {
                    tvkPrgBar.Value = tavuk.Enerji;
                }
            }

            if (ordek.Yasam == true)
            {
                if (ordekPrgBar.Value <= 0)
                {
                    ordek.Yasam = false;
                    lblOrdekYasam.Text = "ÖLÜ";
                }
                else
                {
                    ordekPrgBar.Value = ordek.Enerji;

                }
            }

            if (keci.Yasam == true)
            {
                if (KeciPrgBar.Value <= 0)
                {
                    keci.Yasam = false;
                    lblKeciYasam.Text = "ÖLÜ";
                }
                else
                {
                    KeciPrgBar.Value = keci.Enerji;

                }
            }

            lblTavukUrun.Text = tavuk.UrunAdeti.ToString();
            lblKeciUrun.Text = keci.UrunAdeti.ToString();
            lblOrdekUrun.Text = ordek.UrunAdeti.ToString();
            lblInekUrun.Text = inek.UrunAdeti.ToString();
        }

        private void btnTavukSat_Click(object sender, EventArgs e)
        {
            if(lblTavukUrun.Text != "0")
            {
                tavuk.UrunAdeti--;
                kasaParasi++;
            }
        }

        private void btnOrdekSat_Click(object sender, EventArgs e)
        {
            if(lblOrdekUrun.Text != "0")
            {
                ordek.UrunAdeti--;
                kasaParasi += 3;
            }
        }

        private void btnInekSat_Click(object sender, EventArgs e)
        {
            if (lblInekUrun.Text != "0")
            {
                inek.UrunAdeti--;
                kasaParasi += 5;
            }
        }

        private void btnKeciSat_Click(object sender, EventArgs e)
        {
            if (lblKeciUrun.Text != "0")
            {
                keci.UrunAdeti--;
                kasaParasi += 8;
            }
        }

        private void tvkPrgBar_Click(object sender, EventArgs e)
        {

        }
    }
}
