using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementRoi : ComportementSeDeplacerAbstrait
	{
		public DeplacementRoi ()
		{
		}

        public override void SeDeplacer(Case c)
        {
            throw new NotImplementedException();
        }

        public override List<Case> deplacementPossible()
        {
            throw new NotImplementedException();
        }
    }
}

