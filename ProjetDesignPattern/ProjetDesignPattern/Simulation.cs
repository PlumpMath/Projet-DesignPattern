using System;
using System.Collections.Generic;

namespace ProjetDesignPattern
{
    public class Simulation
    {
        public String Nom { get; set; }

        public int numTour;
        public List<SujetObserveAbstrait> listeSujetsObserves;
        public List<PersonnageAbstrait> listePersonnages;
        public List<ConflitAbstrait> listeConflits;
        public List<ObjetAbstrait> listeObjets;

        public ModuleStatsAbstrait ModuleStats { get; set; }
        public ModuleIHMAbstrait ModuleIHM { get; set; }
        public FabriqueAbstraite fab { get; set; }


        public Simulation(String unNom)
        {
            Nom = unNom;
            listePersonnages = new List<PersonnageAbstrait>();
            listeSujetsObserves = new List<SujetObserveAbstrait>();
            listeConflits = new List<ConflitAbstrait>();
            listeObjets = new List<ObjetAbstrait>();
        }

        public void TourDeJeu()
        {
            foreach (SujetObserveAbstrait sujet in listeSujetsObserves)
            {
                sujet.Notifier();
            }
            foreach (PersonnageAbstrait perso in listePersonnages)
            {
                perso.AnalyserSituation();
                perso.Execution();
            }
            foreach (ConflitAbstrait conflit in listeConflits)
            {
                conflit.Mediation();
            }
            foreach (ObjetAbstrait objet in listeObjets)
            {
                objet.MiseAJour();
            }
            RecupererInformation();
            CalculStatistiques();
            Afficher();
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
            ModuleStats.RecupererInformation();
        }

        public void CalculStatistiques()
        {
            ModuleStats.CalculStatistiques();
        }

    }
}
