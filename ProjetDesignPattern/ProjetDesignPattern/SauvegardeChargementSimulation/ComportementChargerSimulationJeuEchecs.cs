using System;
using System.Xml.XPath;


namespace ProjetDesignPattern
{
	public class ComportementChargerSimulationJeuEchecs : ComportementChargerSimulationAbstrait
	{


		private XPathDocument document;


		public ComportementChargerSimulationJeuEchecs (Simulation _simulation, XPathDocument _document)
		{
			this.simulation = _simulation;
			this.document = _document;
			this.fabrique = new JeuEchecs.FabriqueJeuEchecs();
		}

		public override void chargerLesPersonnages()
		{
			XPathNavigator navigator = document.CreateNavigator();

			XPathNodeIterator nodesPersonnages = navigator.Select("/Simulation/Jeu/Personnages/Personnage");


			foreach (XPathNavigator tempPersonnage in nodesPersonnages)
			{
				string nom = tempPersonnage.SelectSingleNode("nom")==null ? string.Empty : tempPersonnage.SelectSingleNode("nom").Value;
				string pv = tempPersonnage.SelectSingleNode("pv")==null ? string.Empty : tempPersonnage.SelectSingleNode("pv").Value;
				string type = tempPersonnage.SelectSingleNode("type")==null ? string.Empty : tempPersonnage.SelectSingleNode("type").Value;
				//string etat = tempPersonnage.SelectSingleNode("etat")==null ? string.Empty : tempPersonnage.SelectSingleNode("etat").Value;

				//TODO Ce n'est pas correctement initialiser 
				//string zonePresent = tempPersonnage.SelectSingleNode("zonePresent")==null ? string.Empty : tempPersonnage.SelectSingleNode("zonePresent").Value;

				PersonnageAbstrait personnage = fabrique.CreerPersonnage (type, nom, pv, null, null,null);
				simulation.listePersonnages.Add (personnage);
			}
		}

		public override void chargerLesZones()
		{
			XPathNavigator navigator = document.CreateNavigator();

			XPathNodeIterator nodesPersonnages = navigator.Select("/Simulation/Jeu/zones/zone");


			foreach (XPathNavigator tempPersonnage in nodesPersonnages)
			{
				string x = tempPersonnage.SelectSingleNode("x")==null ? string.Empty : tempPersonnage.SelectSingleNode("nom").Value;
				string y = tempPersonnage.SelectSingleNode("y")==null ? string.Empty : tempPersonnage.SelectSingleNode("pv").Value;
				string idZone = tempPersonnage.GetAttribute("idzone")==null ? string.Empty : tempPersonnage.GetAttribute("idzone").Value;

				//TODO Ce n'est pas correctement initialiser 
				//string zonePresent = tempPersonnage.SelectSingleNode("zonePresent")==null ? string.Empty : tempPersonnage.SelectSingleNode("zonePresent").Value;

				ZoneAbstraite zone = fabrique.CreerZone ();
				simulation.listeZones.Add (zone);
			}
			//fabrique.CreerZone

		}

		public override void chargerLesAcces()
		{
			//Boucler sur la liste des zone si il y a match on enregistre sinon non

		}
	}
}

