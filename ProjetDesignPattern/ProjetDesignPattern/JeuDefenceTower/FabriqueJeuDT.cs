using System;
using System.Collections.Generic;


namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {
        public const int typeChateau = 1;
        public const int typeEnnemi = 2;

        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom, ZoneAbstraite unePosition)

        {
            //château
            if (typePerso == 1)
            {
                Chateau c = new Chateau(unNom);
                return c;
            }
            //ennemi
            else
            {
                Ennemi e = new Ennemi(unNom,unePosition);
                return e;
            }
        }

		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int positionY)
        {
            return new ZoneDT();
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
