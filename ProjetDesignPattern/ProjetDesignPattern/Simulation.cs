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
        public List<ZoneAbstraite> listeZones;
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
            listeZones = new List<ZoneAbstraite>();
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
            //ModuleStats.RecupererInformation();
        }

        public void CalculStatistiques()
        {
            //ModuleStats.CalculStatistiques();
        }

		/*
		 * Alex
		 * Fonction d'entrée pour le chargement d'une simulation sauvegarder au format XML, 
		 * retourne une simulation complète, cette méthode doit être appelé par l'action de l'utilisateur
		 * qui cliquera sur fichier/charger simulation dans l'IHM, avant l'appel de cette 
		 * fonction une popUp doit lui permetre de selectionner le fichier XML de sauvegarde.
		 * Il prend donc en entré un fichier.
		 * 
		*/
		public void chargerSimulation(String _emplacementFichierXML ){

			ChargerSimulation chargement = new ChargerSimulation (this, _emplacementFichierXML);

			chargement.extractionDesDonnes ();

		}

    }
}
