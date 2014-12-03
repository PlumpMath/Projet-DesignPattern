using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementFou : ComportementSeDeplacer
	{
		public DeplacementFou ()
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

