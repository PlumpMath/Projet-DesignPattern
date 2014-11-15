using System;
using System.Collections.Generic;

namespace ProjetDesignPattern
{
    public abstract class JeuAbstrait
    {
        public int numTour;
        public List<PersonnageAbstrait> listePersonnages;
        public List<ConflitAbstrait> listeConflits;

        public ModuleStatsAbstrait ModuleStats { get; set; }
        public ModuleIHMAbstrait ModuleIHM { get; set; }

        public abstract void TourDeJeu();
        public abstract void Afficher();
        public abstract void Sauvegarder();
        public abstract void RecupererInformation();
        public abstract void CalculStatistiques();
    }
}
