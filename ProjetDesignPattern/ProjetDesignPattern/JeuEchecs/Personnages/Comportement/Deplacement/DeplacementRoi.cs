using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementRoi : ComportementSeDeplacer
	{
		public DeplacementRoi ()
		{
		}

        public override void SeDeplacer(Case c)
        {
            throw new NotImplementedException();
        }

        public override System.Collections.Generic.List<Case> deplacementPossible()
        {
            throw new NotImplementedException();
        }
    }
}

