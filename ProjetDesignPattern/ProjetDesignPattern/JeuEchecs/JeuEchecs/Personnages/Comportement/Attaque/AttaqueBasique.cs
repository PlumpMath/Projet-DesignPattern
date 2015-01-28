using System;
using System.Collections.Generic;

namespace ProjetDesignPattern.JeuEchecs
{
	public class AttaqueBasique:ComportementCombattreJE
	{

		public AttaqueBasique ()
		{
			attaque = 1;
		}

		public override void combattre(int degat, PersonnageAbstrait cible){
			throw new NotImplementedException ();
		}
	}
}

