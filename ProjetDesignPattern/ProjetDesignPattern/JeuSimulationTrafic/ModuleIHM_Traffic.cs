using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class ModuleIHM_Trafic : ModuleIHMAbstrait
    {
        IHM_Traffic ihm = new IHM_Traffic();

        public override void afficher()
        {
            String texte = "";
            int numZone = 1;
            foreach(ZoneAbstraite zone in jeu.listeZones)
            {
                texte += "Zone " + numZone + " :" + "\n";
                foreach(PersonnageAbstrait persoZone in zone.listePersonnages){
                    texte += "\t- " + persoZone.Nom ;
                    if (persoZone.GetType() == typeof(FeuSignalisation))
                    {
                        if (((FeuSignalisation)persoZone).Etat == FeuSignalisation.vert)
                        {
                            texte += " vert ("+ persoZone.PV + ")";
                        }
                        else
                        {
                            texte += " rouge (" + persoZone.PV + ")";
                        }
                    }
                    texte += "\n";
                }
                numZone++;
            }

            ihm.changeTexteBox(texte);


            foreach (ZoneAbstraite zone in jeu.listeZones)
            {
                String nomImageZone = "z" + zone.positionY + zone.positionX;
                if (zone.listePersonnages.Count > 0)
                {
                    foreach (PersonnageAbstrait persoZone in zone.listePersonnages)
                    {
                        if (persoZone.GetType() == typeof(Voiture))
                        {
                            PictureBox p = ihm.Controls.Find(nomImageZone, true).FirstOrDefault() as PictureBox;
                            p.BackgroundImage = ProjetDesignPattern.Properties.Resources.voiture;
                        }
                        else
                        {
                            PictureBox p = ihm.Controls.Find(nomImageZone, true).FirstOrDefault() as PictureBox;
                            p.BackgroundImage = ProjetDesignPattern.Properties.Resources.vide;
                        }
                    }
                }
                else
                {
                    PictureBox p = ihm.Controls.Find(nomImageZone, true).FirstOrDefault() as PictureBox;
                    p.BackgroundImage = ProjetDesignPattern.Properties.Resources.vide;
                }
            }

            ihm.Show();
            ihm.Refresh();
        }
    }
}
