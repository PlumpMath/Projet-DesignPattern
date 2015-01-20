using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public abstract class Véhicule : PersonnageAbstrait
    {
        bool peutAvancer;
        bool feuEstVert;

        public override void AnalyserSituation()
        {
            //Si feu vert et personne devant
            if (feuEstVert)
            {
                peutAvancer = true;
            }
            else
            {
                peutAvancer = false;
            }
        }

        public override void Execution()
        {
            //Si on peut avancer, on le fait
            if (peutAvancer)
            {
                List<ZoneAbstraite> listeZones = comportementSeDeplacer.déplacementPossible(Position);
                if(listeZones.Count > 0)
                    SeDeplacer(listeZones[0]);
            }
        }

        public override void MiseAJour()
        {
            if (EtatMajor.Etat == FeuSignalisation.vert)
            {
                feuEstVert = true;
            }
            else
            {
                feuEstVert = false;
            }
        }
    }
}
