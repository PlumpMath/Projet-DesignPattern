using System;
using System.Xml.XPath;
using System.Collections.Generic;
using ProjetDesignPattern.JeuDefenceTower;


namespace ProjetDesignPattern
{
	public class ComportementChargerSimulationJeuDefenceTower : ComportementChargerSimulationAbstrait
	{


		private XPathDocument document;


		public ComportementChargerSimulationJeuDefenceTower (Simulation _simulation, XPathDocument _document, string _typeJeu)
		{
			this.simulation = _simulation;
			this.document = _document;
		}

		public override void chargerLesPersonnages()
		{
			XPathNavigator navigator = document.CreateNavigator();

			XPathNodeIterator nodesPersonnages = navigator.Select("/Simulation/Jeu/Personnages/Personnage");


			foreach (XPathNavigator tempPersonnage in nodesPersonnages)
			{
				string id = tempPersonnage.GetAttribute("idPersonnage","")==null ? string.Empty : tempPersonnage.GetAttribute("idPersonnage","");
				string nom = tempPersonnage.SelectSingleNode("nom")==null ? string.Empty : tempPersonnage.SelectSingleNode("nom").Value;
				string pv = tempPersonnage.SelectSingleNode("pv")==null ? string.Empty : tempPersonnage.SelectSingleNode("pv").Value;
				string type = tempPersonnage.SelectSingleNode("type")==null ? string.Empty : tempPersonnage.SelectSingleNode("type").Value;
				string etat = tempPersonnage.SelectSingleNode("etat")==null ? string.Empty : tempPersonnage.SelectSingleNode("etat").Value;
				string zonePresent = tempPersonnage.SelectSingleNode("zonePresent")==null ? string.Empty : tempPersonnage.SelectSingleNode("zonePresent").Value;

				string attaque = tempPersonnage.SelectSingleNode("attaque")==null ? string.Empty : tempPersonnage.SelectSingleNode("attaque").Value;

				string nbBalles = tempPersonnage.SelectSingleNode("nbBalles")==null ? null : tempPersonnage.SelectSingleNode("nbBalles").Value;


				int _zonePresent = Convert.ToInt32 (zonePresent);
				int _id = Convert.ToInt32 (id);

				int _pv = Convert.ToInt32 (pv);
				int _attaque = Convert.ToInt32 (attaque);
				int _nbBalle = Convert.ToInt32 (nbBalles);



				ZoneAbstraite zone = simulation.listeZones.Find(item => item.idZone == _zonePresent);

				//PersonnageAbstrait personnage = fabrique.CreerPersonnage (_id,type, nom, pv, etat, zone,null);

				if (nbBalles != null && type.Equals ("chateau")) {
					JeuDefenceTower.Chateau chateau = (JeuDefenceTower.Chateau)fabrique.CreerPersonnage(_id, type, nom,pv, etat, zone,null);
					chateau.initChateau(_pv,_attaque ,_nbBalle,simulation);
					simulation.listePersonnages.Add (chateau);
				} else {
					JeuDefenceTower.Ennemi ennemi = (JeuDefenceTower.Ennemi)fabrique.CreerPersonnage(_id, type, nom,pv, etat, zone,null);
					JeuDefenceTower.Chateau chateau = (JeuDefenceTower.Chateau)simulation.listePersonnages.Find (item => item.Nom == "Chateau");
					ennemi.initEnnemi(chateau, _pv, _attaque);
					simulation.listePersonnages.Add (ennemi);
				}
			}
		}

		public override void chargerLesZones()
		{
			XPathNavigator navigator = document.CreateNavigator();

			XPathNodeIterator nodeZones = navigator.Select("/Simulation/Jeu/zones/zone");


			foreach (XPathNavigator tempZone in nodeZones)
			{
				string x = tempZone.SelectSingleNode("x")==null ? string.Empty : tempZone.SelectSingleNode("x").Value;
                string y = tempZone.SelectSingleNode("y") == null ? string.Empty : tempZone.SelectSingleNode("y").Value;
                string nomImage = tempZone.SelectSingleNode("x") == null ? string.Empty : tempZone.SelectSingleNode("nomImage").Value;
				string idZone = tempZone.GetAttribute("idzone","")==null ? string.Empty : tempZone.GetAttribute("idzone","");


				int _idZone = Convert.ToInt32 (idZone);
				int _x = Convert.ToInt32 (x);
				int _y = Convert.ToInt32 (y);

				ZoneAbstraite zone = fabrique.CreerZone (_idZone, null, null, _x, _y);
                ((ZoneDT)zone).nomImageZone = nomImage;
				simulation.listeZones.Add (zone);
			}
		}

		public override void chargerLesAcces()
		{
			//Boucler sur la liste des zone si il y a match on enregistre sinon non
			XPathNavigator navigator = document.CreateNavigator();

			XPathNodeIterator nodeAcess = navigator.Select("/Simulation/Jeu/Access/acces");

			foreach (XPathNavigator tempAcces in nodeAcess) {

				string depart = tempAcces.SelectSingleNode ("depart") == null ? string.Empty : tempAcces.SelectSingleNode ("depart").Value;
				string arrivee = tempAcces.SelectSingleNode ("arrivee") == null ? string.Empty : tempAcces.SelectSingleNode ("arrivee").Value;

				int _depart = Convert.ToInt32 (depart);
				int _arrivee = Convert.ToInt32 (arrivee);

				ZoneAbstraite zoneDepart = simulation.listeZones.Find(item => item.idZone == _depart);
				ZoneAbstraite zoneArrivee = simulation.listeZones.Find(item => item.idZone == _arrivee);

				if(zoneDepart != null && zoneDepart != null){
					AccesAbstrait acces = fabrique.CreerAcces (zoneDepart, zoneArrivee, true);
					zoneDepart.listeAccess.Add (acces);
				}

			}

		}


		public override void chargerListeObjetParZoneEtPourSimulation(){
			/*XPathNavigator navigator = document.CreateNavigator();

			XPathNodeIterator nodeAcess = navigator.Select("/Simulation/Jeu/objets/objet");

			foreach (XPathNavigator temObjet in nodeAcess) {

				string nom = temObjet.SelectSingleNode ("nom") == null ? string.Empty : temObjet.SelectSingleNode ("nom").Value;
				string zone = temObjet.SelectSingleNode ("zone") == null ? string.Empty : temObjet.SelectSingleNode ("zone").Value;

				int zoneId = Convert.ToInt32 (zone);

				ZoneAbstraite zoneSelectionnee = simulation.listeZones.Find(item => item.idZone == zoneId);

				ObjetAbstrait objet = fabrique.CreerObjet (nom, zoneSelectionnee);
				if (objet != null) {
					this.simulation.listeObjets.Add (objet);
					if (zoneSelectionnee != null) {
						zoneSelectionnee.listeObjets.Add (objet);
					}
				}
			}*/
		}

		public override void chargerListeObjervateurParPersonnage(){
			/*XPathNavigator navigator = document.CreateNavigator();

			XPathNodeIterator nodeAcess = navigator.Select("/Simulation/Jeu/observes/observe");

			foreach (XPathNavigator temObjet in nodeAcess) {

				string idPersonnage = temObjet.SelectSingleNode ("idPersonnage") == null ? string.Empty : temObjet.SelectSingleNode ("idPersonnage").Value;
				int _idPersonnage = Convert.ToInt32 (idPersonnage);

				PersonnageAbstrait personnageObserve = simulation.listePersonnages.Find(item => item.idPersonnage == _idPersonnage);


				XPathNodeIterator nodeAcess2 = temObjet.Select("observateurs/idPersonnage");

				foreach (XPathNavigator temObjet2 in nodeAcess2) {
					string idPersonnageObservateur = temObjet2.Value == null ? string.Empty : temObjet2.Value;
					int _idPersonnageObservateur = Convert.ToInt32 (idPersonnageObservateur);

					PersonnageAbstrait personnageObservervateur = simulation.listePersonnages.Find(item => item.idPersonnage == _idPersonnageObservateur);
					personnageObserve.EtatMajor.AjouterObservateur (personnageObservervateur);
				}
				this.simulation.listeSujetsObserves.Add (personnageObserve.EtatMajor);
			}*/
		}


		public override void chargerListePersonnageParZone(){
			foreach (ZoneAbstraite tempZone in simulation.listeZones) {
				List<PersonnageAbstrait> listePerso = simulation.listePersonnages.FindAll(item => item.Position.idZone == tempZone.idZone);
				tempZone.listePersonnages = listePerso;
			}
		}
	}
}

