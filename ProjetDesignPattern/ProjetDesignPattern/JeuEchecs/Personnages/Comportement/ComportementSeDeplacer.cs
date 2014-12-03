using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementSeDeplacer : ComportementSeDeplacerAbstrait
    {
		Case actuelle { get; set;}

        public abstract void seDeplacer(Case arrivée);

		public abstract List<Case> deplacementPossible ();


    }
}
