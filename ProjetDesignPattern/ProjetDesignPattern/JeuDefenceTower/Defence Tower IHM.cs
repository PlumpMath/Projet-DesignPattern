using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public partial class FormDT : Form
    {
        Simulation simDT;
        public FormDT(Simulation _s)
        {
            InitializeComponent();
            simDT = _s;
        }

        private void attaqueUnEnnemi(int posX, int posY)
        {
            //si y a un perso sur la case il est touché
            ZoneDT zoneCliquée = (ZoneDT)simDT.listeZones.Find(it => it.positionX==posX && it.positionY==posY);
            if (zoneCliquée.listePersonnages.Count > 0)
            {
                Ennemi e = (Ennemi)zoneCliquée.listePersonnages[0];
                e.touché = true;
            }
        }

        private void Recharger_Click(object sender, EventArgs e)
        {
            Chateau chateau = (Chateau)simDT.listePersonnages.Find(c => c.GetType() == typeof(Chateau));
            chateau.Recharger();
        }

        private void z90_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9,0);
        }

        private void z91_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 0);

        }

        private void z92_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 2);
        }

        private void z93_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 3);
        }

        private void z94_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 4);
        }

        private void z95_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 5);
        }

        private void z96_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 6);
        }

        private void z97_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 7);
        }

        private void z98_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 8);
        }

        private void z99_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 9);
        }

        private void z910_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(9, 10);
        }

        private void z80_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 0);
        }

        private void z81_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 1);
        }

        private void z82_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 2);
        }

        private void z83_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 3);
        }

        private void z84_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 4);
        }

        private void z85_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 5);
        }

        private void z86_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 6);
        }

        private void z87_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 7);
        }

        private void z88_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 8);
        }

        private void z89_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 9);
        }

        private void z810_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(8, 10);
        }

        private void z70_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 0);
        }

        private void z71_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 1);
        }

        private void z72_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 2);
        }

        private void z73_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 3);
        }

        private void z74_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 4);
        }

        private void z75_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 5);
        }

        private void z76_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 6);
        }

        private void z77_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 7);
        }

        private void z78_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 8);
        }

        private void z79_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 9);
        }

        private void z710_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(7, 10);
        }

        private void z60_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 0);
        }

        private void z61_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 1);
        }

        private void z62_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 2);
        }

        private void z63_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 3);
        }

        private void z64_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 4);
        }

        private void z65_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 5);
        }

        private void z66_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 6);
        }

        private void z67_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 7);
        }

        private void z68_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 8);
        }

        private void z69_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 9);
        }

        private void z610_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(6, 10);
        }

        private void z50_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 0);
        }

        private void z51_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 1);
        }

        private void z52_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 2);
        }

        private void z53_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 3);
        }

        private void z54_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 4);
        }

        private void z55_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 5);
        }

        private void z56_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 6);
        }

        private void z57_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 7);
        }

        private void z58_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 8);
        }

        private void z59_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 9);
        }

        private void z510_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(5, 10);
        }

        private void z40_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 0);
        }

        private void z41_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 1);
        }

        private void z42_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 2);
        }

        private void z43_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 3);
        }

        private void z44_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 4);
        }

        private void z45_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 5);
        }

        private void z46_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 6);
        }

        private void z47_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 7);
        }

        private void z48_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 8);
        }

        private void z49_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 9);
        }

        private void z410_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(4, 10);
        }

        private void z30_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 0);
        }

        private void z31_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 1);
        }

        private void z32_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 2);
        }

        private void z33_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 3);
        }

        private void z34_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 4);
        }

        private void z35_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 5);
        }

        private void z36_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 6);
        }

        private void z37_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 7);
        }

        private void z38_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 8);
        }

        private void z39_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 9);
        }

        private void z310_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(3, 10);
        }

        private void z20_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 0);
        }

        private void z21_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 1);
        }

        private void z22_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 2);
        }

        private void z23_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 3);
        }

        private void z24_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 4);
        }

        private void z25_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 5);
        }

        private void z26_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 6);
        }

        private void z27_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 7);
        }

        private void z28_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 8);
        }

        private void z29_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 9);
        }

        private void z210_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(2, 10);
        }

        private void z10_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 0);
        }

        private void z11_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 1);
        }

        private void z12_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 2);
        }

        private void z13_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 3);
        }

        private void z14_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 4);
        }

        private void z15_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 5);
        }

        private void z16_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 6);
        }

        private void z17_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 7);
        }

        private void z18_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 8);
        }

        private void z19_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 9);
        }

        private void z110_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(1, 10);
        }

        private void z00_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 0);
        }

        private void z01_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 1);
        }

        private void z02_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 2);
        }

        private void z03_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 3);
        }

        private void z04_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 4);
        }

        private void z05_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 5);
        }

        private void z06_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 6);
        }

        private void z07_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 7);
        }

        private void z08_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 8);
        }

        private void z09_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 9);
        }

        private void z010_Click(object sender, EventArgs e)
        {
            attaqueUnEnnemi(0, 10);
        }


    }
}
