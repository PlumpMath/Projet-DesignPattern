using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
    class FabriqueJeuEchecs : FabriqueAbstraite
	{
		public const string typePion = "0";
		public const string typeTour = "1";
		public const string typeCavalier = "2";
		public const string typeFou = "3";
		public const string typeRoi = "4";
		public const string typeReine = "5";

        
		public override PersonnageAbstrait CreerPersonnage(int _id, string _type, string _nom,string _pv, string _etat,ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
        {
			PersonnageAbstrait piece = null;
			switch (_type) {
			case typePion:
				piece = new Pion ();
				piece.comportementCombattre = new AttaqueBasique ();
				piece.comportementSeDeplacer = new DeplacementPion (_nom[0] == 'W');
				piece.comporterSeDefendre = new AucuneDefense ();
				break;
			case typeTour:
				piece = new Tour ();
				piece.comportementCombattre = new AttaqueBasique ();
				piece.comportementSeDeplacer = new DeplacementTour ();
				piece.comporterSeDefendre = new AucuneDefense ();
				break;
			case typeCavalier:
				piece = new Cavalier ();
				piece.comportementCombattre = new AttaqueBasique ();
				piece.comportementSeDeplacer = new DeplacementCavalier ();
				piece.comporterSeDefendre = new AucuneDefense ();
				break;
			case typeFou:
				piece = new Fou ();
				piece.comportementCombattre = new AttaqueBasique ();
				piece.comportementSeDeplacer = new DeplacementFou ();
				piece.comporterSeDefendre = new AucuneDefense ();
				break;
			case typeRoi:
				piece = new Roi ();
				piece.comportementCombattre = new AttaqueBasique ();
				piece.comportementSeDeplacer = new DeplacementRoi ();
				piece.comporterSeDefendre = new AucuneDefense ();
				break;
			case typeReine:
				piece = new Reine ();
				piece.comportementCombattre = new AttaqueBasique ();
				piece.comportementSeDeplacer = new DeplacementReine ();
				piece.comporterSeDefendre = new AucuneDefense ();
				break;
			}
			if (piece != null) {
				piece.Nom = _nom;
				piece.PV = int.Parse (_pv);
				piece.comportementSeDeplacer.personnage = piece;
				piece.comporterSeDefendre.personnage = piece;
				piece.Position = _position;
				_position.listePersonnages.Add(piece);
			}
			return piece;
        }

		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int _positionY)
        {
			ZoneAbstraite zone = new Case ();
			zone.listePersonnages = _listePersonnages;
			zone.listeObjets = _listeObjets;
			zone.positionX = _positionX;
			zone.positionY = _positionY;

			return zone;
        }
		public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces)
        {
			AccesAbstrait acces = new AccesCase();
			acces.départ = _zoneDepart;
			acces.arrivée = _zoneArrivee;
			acces.accès = true;

			int id;
			if (_zoneDepart.positionX != _zoneArrivee.positionX) {
				if (_zoneDepart.positionX < _zoneArrivee.positionX)
					id = 6;
				else
					id = 4;
			} else {
				if (_zoneDepart.positionY < _zoneArrivee.positionY)
					id = 8;
				else
					id = 2;
			}
			//Ajout de l'accès à la zone départ
			_zoneDepart.zonesAdjacentes.Add(id, acces);

			return acces;
        }

		public override ObjetAbstrait CreerObjet(string _nom,ZoneAbstraite _position){
			return null;
		}
    }
}
