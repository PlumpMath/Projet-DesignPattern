using System;
using System.Xml.XPath;
using System.Xml;
using System.IO;
using System.Xml;

namespace ProjetDesignPattern
{
	public class ChargerSimulation
	{
		private String emplacementFichierSauvegarde;
		private Simulation Simulation;
		private ComportementChargerSimulationAbstrait comportementChargement;


		public ChargerSimulation (Simulation _simulation,String _emplacementFichier)
		{
			emplacementFichierSauvegarde = _emplacementFichier;
			Simulation = _simulation;
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

				this.initialisationDuComportementDeChargement(typeJeu,document); 

				if(comportementChargement != null){
					this.comportementChargement.chargerLesZones();
					this.comportementChargement.chargerLesAcces();
					this.comportementChargement.chargerLesPersonnages();
				}

			}catch(Exception e){
				Console.WriteLine("Erreur lors du chargement de la simulation, Exception: {0}", e.Source);
			}
		}


		private void initialisationDuComportementDeChargement(String _typeJeu, XPathDocument _document){

			switch(_typeJeu){
			case "JeuEchecs":
				comportementChargement = new ComportementChargerSimulationJeuEchecs (this.Simulation, _document);
				break;
			/*case "JeuDefenceTower":
				//return null;
			case "JeuSimulationTrafic":*/
				//return null;
			default:
				comportementChargement = null;
				break;

			}

		}
	}
}

