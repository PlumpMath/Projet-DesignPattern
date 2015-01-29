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
            //Affichage du plateau
            foreach (ZoneDT zone in jeu.listeZones)
            {
                if (zone.listePersonnages.Count > 0)
                {
                    foreach (PersonnageAbstrait e in zone.listePersonnages)
                    {
                        if (e.GetType() == typeof(Ennemi))
                        {
                            if (((Ennemi)e).arrivéChateau)
                            {
                                //ennemi arrivé au château -> position attaque
                                PictureBox p = ihm.Controls.Find(zone.nomImageZone, true).FirstOrDefault() as PictureBox;
                                p.BackgroundImage = ProjetDesignPattern.Properties.Resources.EnnemiAttaque;
                            }
                            else
                            {
                                if (((Ennemi)e).apparu == true)
                                {
                                    //ennemi apparait -> position marche
                                    PictureBox p = ihm.Controls.Find(zone.nomImageZone, true).FirstOrDefault() as PictureBox;
                                    p.BackgroundImage = ProjetDesignPattern.Properties.Resources.EnnemiMarche;
                                }
                                else
                                {
                                    //case vide
                                    PictureBox p = ihm.Controls.Find(zone.nomImageZone, true).FirstOrDefault() as PictureBox;
                                    p.BackgroundImage = ProjetDesignPattern.Properties.Resources.EnnemiVide;
                                }
                                              
                            }
                        }
                        
                    }
                }
                else
                {                   
                    //case vide
                    PictureBox p = ihm.Controls.Find(zone.nomImageZone, true).FirstOrDefault() as PictureBox;
                    p.BackgroundImage = ProjetDesignPattern.Properties.Resources.EnnemiVide;
                }
            }

            //Affichage des stats
            ihm.vieChateau.Text = ((ModuleStat_DT)jeu.ModuleStats).vieChateau.ToString();
            ihm.degatEnnemi.Text = ((ModuleStat_DT)jeu.ModuleStats).totalDégâtsAuxEnnemis.ToString();
            ihm.degatChateau.Text = ((ModuleStat_DT)jeu.ModuleStats).totalDégâtsAuChâteau.ToString();
            ihm.morts.Text = ((ModuleStat_DT)jeu.ModuleStats).nbMorts.ToString();
            ihm.nbBalles.Text = ((ModuleStat_DT)jeu.ModuleStats).nbBalles.ToString();

            //ihm.ShowDialog();
            ihm.Show();
            ihm.Refresh();
        }
    }
}
