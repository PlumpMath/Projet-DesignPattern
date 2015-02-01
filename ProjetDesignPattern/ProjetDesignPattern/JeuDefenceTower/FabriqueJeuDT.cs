using System;
using System.Collections.Generic;


namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {    
        public override PersonnageAbstrait CreerPersonnage(int _id, string _type, string _nom, string _pv, string _etat, ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
        {
            //château
            if (_type == "chateau")
            {
                Chateau c = new Chateau(_nom);
				c.idPersonnage = _id;
				c.Nom = _nom;

                return c;
            }
            //ennemi
            else
            {
                Ennemi e = new Ennemi(_nom, _position);
				e.idPersonnage = _id;
				e.Nom = _nom;
                return e;
            }
        }

		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int _positionY)
        {
			ZoneAbstraite zone = new ZoneDT();
			zone.listeAccess = new List<AccesAbstrait>();
			zone.positionX = _positionX;
			zone.positionY = _positionY;
			zone.listePersonnages = _listePersonnages;
			zone.listeObjets = _listeObjets;
			zone.idZone = _idzone;
			zone.zonesAdjacentes = new Dictionary<int, AccesAbstrait>();

			return zone;        
		}

		public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces)
        {
            AccesAbstrait acces = new AccesDT();
            acces.départ = _zoneDepart;
            acces.arrivée = _zoneArrivee;

            //Ajout de l'accès à la zone départ
            _zoneDepart.zonesAdjacentes.Add(1, acces);

            return acces;
        }

		public override ObjetAbstrait CreerObjet(string _nom,ZoneAbstraite _position){
			return null;
		}

    }
}
