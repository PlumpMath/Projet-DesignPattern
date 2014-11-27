using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public class AttaqueBasique:ComportementCombattre
	{

		public AttaqueBasique ()
		{
			attaque = 1;
		}

		public override int combattre(){
			return attaque;
		}
	}
}

