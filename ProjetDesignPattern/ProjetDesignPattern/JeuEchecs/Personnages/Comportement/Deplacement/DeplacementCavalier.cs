using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public class DeplacementCavalier : ComportementSeDeplacer
	{
		public DeplacementCavalier ()
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

