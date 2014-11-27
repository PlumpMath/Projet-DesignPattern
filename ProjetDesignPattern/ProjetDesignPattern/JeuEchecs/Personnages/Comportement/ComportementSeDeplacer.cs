using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class ComportementSeDeplacer:ComportementSeDeplacerAbstrait
    {
        public abstract void SeDeplacer(Case c);

		public abstract List<Case> deplacementPossible ();


    }
}
