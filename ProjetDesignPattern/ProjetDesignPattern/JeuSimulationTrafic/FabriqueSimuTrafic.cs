
using System.Collections.Generic;
namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
		public const string typeFeu = "0";
        public const string typeCamion = "1";
		public const string typeVoiture = "2";
		public const string typeMoto = "3";
        
        public override PersonnageAbstrait CreerPersonnage(int _id, string _type, string _nom, string _pv, 
            string _etat, ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
        {
            PersonnageAbstrait perso;
            switch (_type)
            {
			case typeCamion:
				perso = new Camion ();
				perso.comportementSeDeplacer = new ComportementSeDeplacerVoiture ();
                break;
			case typeFeu:
	            perso = new FeuSignalisation();
	            switch (_etat)
	            {
	                case "vert":
	                    ((FeuSignalisation)perso).Etat = FeuSignalisation.vert;
	                    break;
	                case "rouge":
	                    ((FeuSignalisation)perso).Etat = FeuSignalisation.vert;
	                    break;
	            }
	            break;
			case typeVoiture:
	            perso =  new Voiture();
	            perso.comportementSeDeplacer = new ComportementSeDeplacerVoiture();
	            perso.comportementSeDeplacer.personnage = perso;
	            break;
			case typeMoto:
				perso = new Moto ();
				perso.comportementSeDeplacer = new ComportementSeDeplacerVoiture();
				break;
			default:
				perso = null;
	            break;
	    }

			if (perso != null) {
				perso.idPersonnage = _id;
				perso.Nom = _nom;
				perso.Position = _position;
			//_position.listePersonnages.Add (perso);

				if (EtatMajor != null) {
					EtatMajor.AjouterObservateur (perso);
					perso.EtatMajor = EtatMajor;
				}
			}

        return perso;
        }

        public SujetObserveAbstrait CreerSujetObserve()
        {
            SujetObserveAbstrait feu = new FeuSignalisation();

            return feu;
        }

        public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets, int _positionX, int positionY)
        {
            ZoneAbstraite zone = new PortionDeRoute();
			zone.listeAccess = new List<AccesAbstrait>();
            zone.positionX = _positionX;
            zone.positionY = positionY;
            zone.listePersonnages = _listePersonnages;
            zone.listeObjets = _listeObjets;
			zone.idZone = _idzone;
            zone.zonesAdjacentes = new Dictionary<int, AccesAbstrait>();

            return zone;
        }


        public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart, ZoneAbstraite _zoneArrivee, bool _acces)
        {
            AccesAbstrait acces = new AccesRoute();
            acces.départ = _zoneDepart;
            acces.arrivée = _zoneArrivee;

            //Ajout de l'accès à la zone départ
            _zoneDepart.zonesAdjacentes.Add(1, acces);

            return acces;
        }

        public override ObjetAbstrait CreerObjet(string _nom, ZoneAbstraite _position)
        {
            throw new System.NotImplementedException();
        }
    }
}
