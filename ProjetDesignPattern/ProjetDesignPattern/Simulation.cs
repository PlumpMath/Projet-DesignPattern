using System;
using System.Collections.Generic;

namespace ProjetDesignPattern
{
    public class Simulation
    {
        public String Nom { get; set; }

        public int numTour;
        public List<PersonnageAbstrait> listePersonnages;
        public List<ConflitAbstrait> listeConflits;

        public ModuleStatsAbstrait ModuleStats { get; set; }
        public ModuleIHMAbstrait ModuleIHM { get; set; }


        public Simulation(String unNom)
        {
            Nom = unNom;
        }

        public void TourDeJeu()
        {
            foreach (PersonnageAbstrait perso in listePersonnages)
            {
                perso.AnalyserSituation();
                perso.Execution();
            }
            foreach(ConflitAbstrait conflit in listeConflits)
            {
                conflit.Mediation();
            }
        }

        public void Afficher()
        {
            ModuleIHM.afficher();
        }

        public void Sauvegarder()
        {

        }

        public void RecupererInformation()
        {

        }

        public void CalculStatistiques()
        {

        }

    }
}
