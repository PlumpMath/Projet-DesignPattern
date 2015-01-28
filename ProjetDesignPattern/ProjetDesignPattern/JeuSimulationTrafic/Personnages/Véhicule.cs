using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public abstract class Véhicule : PersonnageAbstrait
    {
        bool peutAvancer;
        public bool feuEstVert;

        public override void AnalyserSituation()
        {
            List<ZoneAbstraite> listeZones = comportementSeDeplacer.déplacementPossible(Position);
            //Si zone libre devant ou contient un feu vert
            if (listeZones.Count > 0)
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
