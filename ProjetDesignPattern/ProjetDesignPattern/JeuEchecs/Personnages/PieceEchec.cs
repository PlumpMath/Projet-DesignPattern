using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
    public abstract class PieceEchec : PersonnageAbstrait
    {
        public ComportementSeDeplacer comportementSeDeplacer { get; set; }
		public ComportementCombattre comportementCombattre{ get; set; }
		public ComportementSeDefendre comportementSeDefendre{ get; set;}

		int equipe { get; set; }

		public int combattre(){
			return comportementCombattre.combattre ();
		}

		public int seDefendre(int attaque){
			return comportementSeDefendre.seDefendre(attaque);
		}

		public void seDeplacer(Case c){
			comportementSeDeplacer.seDeplacer (c);
		}
		public List<Case> deplacementPossible (){
			return comportementSeDeplacer.deplacementPossible ();
		}

    }
}
