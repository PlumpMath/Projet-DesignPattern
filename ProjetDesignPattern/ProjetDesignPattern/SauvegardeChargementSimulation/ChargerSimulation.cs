using System;
using System.Xml.XPath;
using System.Xml;
using System.IO;

namespace ProjetDesignPattern
{
	public class ChargerSimulation
	{
		private String emplacementFichierSauvegarde;
		private Simulation simulation;
		private ComportementChargerSimulationAbstrait comportementChargement;


		public ChargerSimulation (Simulation _simulation,String _emplacementFichier)
		{
			emplacementFichierSauvegarde = _emplacementFichier;
			simulation = _simulation;
		}

		/*
		 * Alex : fonction principale permettant de charger toutes les données contenu dans le ficher XML 
		 * de sauvegarde au sein de la simulation
		 */
		public void extractionDesDonnes(){

			try{
				XPathDocument document = new XPathDocument(emplacementFichierSauvegarde);
				XPathNavigator navigator = document.CreateNavigator();

				//Chargement du type de jeu afin de déterminer le comportementChargerSimulation
				XPathNodeIterator nodes = navigator.Select("/Simulation/Jeu[1]/@typeJeu");
				String typeJeu = "";
				foreach (XPathNavigator item in nodes)
				{
					typeJeu = item.Value;
				}

				initialisationDuTypeDeChargement(typeJeu,document);
								 
				//comportementChargement = new ComportementChargerSimulationJeuEchec (this.simulation, document,typeJeu);

				if(comportementChargement != null){
					this.comportementChargement.chargerLesZones();
					this.comportementChargement.chargerLesAcces();
					this.comportementChargement.chargerLesPersonnages();
					this.comportementChargement.chargerListePersonnageParZone();
					this.comportementChargement.chargerListeObjetParZoneEtPourSimulation();
					this.comportementChargement.chargerListeObjervateurParPersonnage();
				}

				Console.WriteLine(simulation);

			}catch(Exception e){
			
				Console.WriteLine("Erreur lors du chargement de la simulation, Exception: {0}", e.Message);
			}
		}

		private void initialisationDuTypeDeChargement(string _type, XPathDocument _document){

		
			simulation.Nom = _type;

			switch(_type){
			case "JeuEchecs":
				comportementChargement = new ComportementChargerSimulationJeuEchecs (this.simulation,_document,null);
				comportementChargement.fabrique = new JeuEchecs.FabriqueJeuEchecs ();

				simulation.ModuleIHM = new JeuEchecs.ModuleIHM_Echecs ();
				simulation.ModuleIHM.jeu = simulation;

				simulation.ModuleStats = new JeuEchecs.ModuleStats_Echecs ();
				simulation.ModuleStats.jeu = simulation;

				break;
			case "JeuDefenceTower":
				comportementChargement = new ComportementChargerSimulationJeuDefenceTower (this.simulation,_document,null);
				comportementChargement.fabrique = new JeuDefenceTower.FabriqueJeuDT ();

				simulation.ModuleIHM = new JeuDefenceTower.ModuleIHMDT (simulation);
				simulation.ModuleIHM.jeu = simulation;

				simulation.ModuleStats = new JeuDefenceTower.ModuleStat_DT ();
				simulation.ModuleStats.jeu = simulation;

				break;
			case "JeuSimulationTrafic":
				comportementChargement = new ComportementChargerSimulationJeuSimulationTraffic (this.simulation,_document,null);
				comportementChargement.fabrique = new JeuSimulationTrafic.FabriqueSimuTrafic ();

				simulation.ModuleIHM = new JeuSimulationTrafic.ModuleIHM_Trafic ();
				simulation.ModuleIHM.jeu = simulation;

				simulation.ModuleStats = new JeuSimulationTrafic.ModuleStats_Trafic ();
				simulation.ModuleStats.jeu = simulation;

				break;
			default:
				comportementChargement = null;
				break;

			}

		}
	}
}

