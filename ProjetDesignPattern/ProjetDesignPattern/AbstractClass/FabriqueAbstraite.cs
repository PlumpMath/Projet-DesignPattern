using System;
using System.Collections.Generic;


namespace ProjetDesignPattern
{
    public abstract class FabriqueAbstraite
    {


		public abstract PersonnageAbstrait CreerPersonnage(int _id, string _type, string _nom,string _pv, string _etat,ZoneAbstraite _position, SujetObserveAbstrait EtatMajor);

		public abstract ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int positionY);

		public abstract AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces);

		public abstract ObjetAbstrait CreerObjet(string _nom,ZoneAbstraite _position);

    }
}
