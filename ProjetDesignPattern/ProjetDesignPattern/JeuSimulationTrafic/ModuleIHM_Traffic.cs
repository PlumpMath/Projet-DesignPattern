using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    class ModuleIHM_Trafic : ModuleIHMAbstrait
    {
        public IHM_Traffic ihm;

        public ModuleIHM_Trafic(Simulation _s)
        {
            ihm = new IHM_Traffic(_s);
        }
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
                PictureBox p = ihm.Controls.Find(nomImageZone, true).FirstOrDefault() as PictureBox;
                if (zone.listePersonnages.Count > 0)
                {
                    bool voiture = false;
                    bool moto = false;
                    bool camion = false;
                    bool feu = false;
                    bool feuVert = false;
                    foreach (PersonnageAbstrait persoZone in zone.listePersonnages)
                    {
                        if (persoZone.GetType() == typeof(Voiture))
                        {
                            voiture = true;
                        }
                        else if (persoZone.GetType() == typeof(Moto))
                        {
                            moto = true;
                        }
                        else if (persoZone.GetType() == typeof(Camion))
                        {
                            camion = true;
                        }
                        else if (persoZone.GetType() == typeof(FeuSignalisation))
                        {
                            feu = true;
                           feuVert =((FeuSignalisation)persoZone).Etat == FeuSignalisation.vert;
                        }
                    }

                    if (voiture)
                    {
                        if (feu)
                        {
                            if (feuVert)
                            {
                                p.BackgroundImage = ProjetDesignPattern.Properties.Resources.voiture_feuV;
                            }
                            else
                            {
                                p.BackgroundImage = ProjetDesignPattern.Properties.Resources.voiture_feuR;
                            }
                        }
                        else
                        {
                            p.BackgroundImage = ProjetDesignPattern.Properties.Resources.voiture;
                        }
                    }
                    else if (moto)
                    {
                        p.BackgroundImage = ProjetDesignPattern.Properties.Resources.moto;
                    }
                    else if (camion)
                    {
                        p.BackgroundImage = ProjetDesignPattern.Properties.Resources.camion;
                    }
                    else if (feu)
                    {
                        if (feuVert)
                        {
                            p.BackgroundImage = ProjetDesignPattern.Properties.Resources.feuV;
                        }
                        else
                        {
                            p.BackgroundImage = ProjetDesignPattern.Properties.Resources.feuR;
                        }
                    }
                }
                else
                {
                    p.BackgroundImage = ProjetDesignPattern.Properties.Resources.vide;
                }
            }

            ihm.Show();
            ihm.Refresh();
        }
    }
}
