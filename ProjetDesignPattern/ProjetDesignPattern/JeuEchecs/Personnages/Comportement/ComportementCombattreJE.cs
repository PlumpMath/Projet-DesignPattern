using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementCombattreJE:ComportementCombattreAbstrait
	{
		public override void combattre(int degat, PersonnageAbstrait cible){
			throw new NotImplementedException ();
		}
	}
}

