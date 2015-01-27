
using System.Collections.Generic;
using System;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
        

		public override PersonnageAbstrait CreerPersonnage(int _id, string _type, string _nom,string _pv, string _etat,ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
		{
		
			PersonnageAbstrait personnage;
			switch(_type){
			case  "Camion":
				personnage = new Camion ();
				personnage.comportementSeDeplacer = new ComportementSeDeplacerCamion ();
				break;
			case "Voiture":
				personnage =  new Voiture();
				personnage.comportementSeDeplacer = new ComportementSeDeplacerVoiture();
				break;
			case "Moto":
				personnage = new Moto ();
				personnage.comportementSeDeplacer = new ComportementSeDeplacerMoto ();
				break;
			default:
				personnage = null;
				break;
			}

			if (personnage != null) {
				personnage.Nom = _nom;
				personnage.Position = _position;
				//personnage.EtatMajor = new SujetObserveEchec ();
			}

			return personnage;
		}

        

		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int positionY){
			ZoneAbstraite zone = new PortionDeRoute ();
			zone.idZone = _idzone;
			zone.positionX = _positionX;
			zone.positionY = positionY;
			return zone;
		}

        
		public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces)
		{
			AccesAbstrait acces = new AccesRoute ();
			acces.départ = _zoneDepart;
			acces.arrivée = _zoneArrivee;
			acces.accès = _acces;

			return acces;
		
		}

		public override ObjetAbstrait CreerObjet(string _nom,ZoneAbstraite _position){
			return null;
		}



    }
}
