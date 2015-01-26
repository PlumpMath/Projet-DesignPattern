using System;
using System.Collections.Generic;


namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public class FabriqueSimuTrafic : FabriqueAbstraite
    {
        enum eTypePersonnage
        {
            Camion,
            Voiture,
            Moto
        }

		public override PersonnageAbstrait CreerPersonnage(int _id,string _type, string _nom,string _pv, string _etat, ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
        {
            /*switch(typePerso){
                case eTypePersonnage.Camion:
                    return new Camion();
                case eTypePersonnage.Voiture:
                    return new Voiture();
                case eTypePersonnage.Moto:
                default:
                    return new Moto();
            }*/
			return null;
        }

		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int positionY)
        {
            throw new System.NotImplementedException();
        }

		public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces)
        {
            throw new System.NotImplementedException();
        }

		public override ObjetAbstrait CreerObjet(string _nom,ZoneAbstraite _position){
			return null;
		}
    }
}
