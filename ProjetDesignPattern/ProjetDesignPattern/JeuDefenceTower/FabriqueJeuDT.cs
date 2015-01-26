using System;
using System.Collections.Generic;


namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {
		public override PersonnageAbstrait CreerPersonnage(int _id,string _type, string _nom,string _pv, string _etat, ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
        {
            throw new NotImplementedException();
        }

		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int positionY)
        {
            throw new NotImplementedException();
        }

		public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces)
        {
            throw new NotImplementedException();
        }

		public override ObjetAbstrait CreerObjet(string _nom,ZoneAbstraite _position){
			return null;
		}

    }
}
