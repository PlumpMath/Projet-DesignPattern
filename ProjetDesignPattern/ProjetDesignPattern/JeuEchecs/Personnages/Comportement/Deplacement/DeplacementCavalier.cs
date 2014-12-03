using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementCavalier : ComportementSeDeplacer
	{
		public DeplacementCavalier ()
		{
		}

        public override void seDeplacer(Case c)
        {
            throw new NotImplementedException();
        }

        public override List<Case> deplacementPossible()
        {
            throw new NotImplementedException();
        }
    }
}

