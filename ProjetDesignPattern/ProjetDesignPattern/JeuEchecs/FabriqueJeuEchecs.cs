using System;
using System.Collections.Generic;


namespace ProjetDesignPattern.JeuEchecs
{
    class FabriqueJeuEchecs : FabriqueAbstraite
    {
		public override PersonnageAbstrait CreerPersonnage(int _id,string _type, string _nom,string _pv, string _etat, ZoneAbstraite _position, SujetObserveAbstrait EtatMajor)
        {
			PersonnageAbstrait personnage;

			//Definition du type du personnage pour la simulation echec
			switch (_type){
			case "Pion":
				personnage = new JeuEchecs.Pion ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementPion ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Tour":
				personnage = new JeuEchecs.Tour ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementTour ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Fou":
				personnage = new JeuEchecs.Fou ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementFou ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Reine":
				personnage = new JeuEchecs.Reine ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementReine ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Cavalier":
				personnage = new JeuEchecs.Cavalier ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementCavalier ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Roi":
				personnage = new JeuEchecs.Roi ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementRoi ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			default:
				personnage = null;
				break;
			}
			//Set des autres attributs d'un personnage
			if (null != personnage) {
				personnage.Nom = _nom;
				personnage.PV = Convert.ToInt32 (_pv);
				personnage.Position = _position;
				personnage.idPersonnage = _id;
				personnage.EtatMajor = (SujetObserveAbstrait) personnage;
				personnage.EtatMajor.observateurList = new List <ObservateurAbstrait>();

			}

			//FAIRE UNE BOUCLE SUR LA LISTE DES ZONNE POUR DEFINIR LA ZONNE 
			//personnage.zonne

			return personnage;
			//switch
			//PieceEchec personnageEchec = new JeuEchecs.PieceEchec ();

        }


	


		public override ZoneAbstraite CreerZone(int _idzone, List<PersonnageAbstrait> _listePersonnages, List<ObjetAbstrait> _listeObjets,int _positionX, int positionY)
		{
			ZoneAbstraite zone = new ZoneE ();
			zone.idZone = _idzone;
			zone.positionX = _positionX;
			zone.positionY = positionY;
			return zone;
		}

		public override AccesAbstrait CreerAcces(ZoneAbstraite _zoneDepart,ZoneAbstraite _zoneArrivee,Boolean _acces)
        {
			AccesAbstrait acces = new AccesE ();
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
