using System;

namespace ProjetDesignPattern.JeuEchecs
{
    class FabriqueJeuEchecs : FabriqueAbstraite
	{
		public const int typePion = 0;
		public const int typeTour = 1;
		public const int typeCavalier = 2;
		public const int typeFou = 3;
		public const int typeRoi = 4;
		public const int typeReine = 5;

        public override PersonnageAbstrait CreerPersonnage(int typePerso, SujetObserveAbstrait unEtatMajor, string unNom, ZoneAbstraite unePosition)
        {
			PersonnageAbstrait piece = null;
			switch (typePerso) {
			case typePion:
				piece = new Pion ();
				piece.comportementCombattre = new AttaqueBasique ();
				piece.comportementSeDeplacer = new DeplacementPion ();
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
				piece.Nom = unNom;
				piece.Position = unePosition;
				unePosition.listePersonnages.Add(piece);
			}
			return piece;
        }

        public override ZoneAbstraite CreerZone()
        {
			ZoneAbstraite zone = new Case ();
			return zone;
        }
        public override AccesAbstrait CreerAcces(ZoneAbstraite départ, ZoneAbstraite arrivée)
        {
			AccesAbstrait acces = new AccesCase();
			acces.départ = départ;
			acces.arrivée = arrivée;
			acces.accès = true;

			int id;
			if (départ.positionX != arrivée.positionX) {
				if (départ.positionX < arrivée.positionX)
					id = 6;
				else
					id = 4;
			} else {
				if (départ.positionY < arrivée.positionY)
					id = 8;
				else
					id = 2;
			}
			//Ajout de l'accès à la zone départ
			départ.zonesAdjacentes.Add(id, acces);

			return acces;
        }
    }
}
