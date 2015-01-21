using System;

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

            ihm.Show();
            ihm.Refresh();
        }
    }
}
