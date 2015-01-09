using System;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public abstract class Véhicule : PersonnageAbstrait
    {
        bool peutAvancer;

        public override void AnalyserSituation()
        {
            //Si feu vert et personne devant
            peutAvancer = true;
            //else
            peutAvancer = false;
        }

        public override void Execution()
        {
            //Si on peut avancer, on le fait
            if (peutAvancer)
            {
                SeDeplacer(Position);
            }
        }

        public override void MiseAJour()
        {

        }
    }
}
