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
                return c;
            }
            //ennemi
            else
            {
                Ennemi e = new Ennemi(_nom, _position);
                return e;
            }
        }

		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int _positionY)
        {
            return new ZoneDT(_listePersonnages, _listeObjets,_positionX, _positionY);
        }

		public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces)
        {
            AccesAbstrait acces = new AccesDT();
            acces.départ = _zoneDepart;
            acces.arrivée = _zoneArrivee;

            //Ajout de l'accès à la zone départ
            acces.départ.zonesAdjacentes.Add(1, acces);

            return acces;
        }

		public override ObjetAbstrait CreerObjet(string _nom,ZoneAbstraite _position){
			return null;
		}

    }
}
