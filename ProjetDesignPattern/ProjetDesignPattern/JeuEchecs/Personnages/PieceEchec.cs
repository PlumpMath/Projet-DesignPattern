using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
    public abstract class PieceEchec : PersonnageAbstrait
    {
		public bool etatRoi = false;

		public bool etatDéplacement = false;
		public ZoneAbstraite futureZone;

       // public ComportementSeDeplacerJE comportementSeDeplacer { get; set; }
	//	public ComportementCombattreJE comportementCombattre{ get; set; }
		public ComportementSeDefendreJE comportementSeDefendre{ get; set;}

		int equipe { get; set; }

		public void combattre(int degat, PieceEchec cible){
			comportementCombattre.combattre (degat, cible);
		}

		public void seDefendre(int attaque){
			comportementSeDefendre.defendre(attaque);
		}

		public void deplacer(Case c){
			comportementSeDeplacer.deplacer (c);
		}

		public List<ZoneAbstraite> deplacementPossible (ZoneAbstraite zone){
			return comportementSeDeplacer.déplacementPossible (zone);
		}
    }
}
