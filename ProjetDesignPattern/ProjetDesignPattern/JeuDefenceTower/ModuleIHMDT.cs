using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class ModuleIHMDT : ModuleIHMAbstrait
    {
        FormDT ihm;

        public ModuleIHMDT(Simulation _s)
        {
            ihm = new FormDT(_s);
        }
        public override void afficher()
        {
            foreach (ZoneDT zone in jeu.listeZones)
            {
                if (zone.listePersonnages.Count > 0)
                {
                    PictureBox p = ihm.Controls.Find(zone.nomImageZone, true).FirstOrDefault() as PictureBox;
                    p.BackgroundImage = ProjetDesignPattern.Properties.Resources.EnnemiMarche;
                }
                else
                {
                    PictureBox p = ihm.Controls.Find(zone.nomImageZone, true).FirstOrDefault() as PictureBox;
                    p.BackgroundImage = ProjetDesignPattern.Properties.Resources.EnnemiVide;

                }
            }

            ihm.ShowDialog();
            ihm.Refresh();
        }
    }
}
