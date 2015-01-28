using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementSeDefendreJE:ComporterSeDefendreAbstrait
	{
		public int defense { get; set;}

		public override void defendre(int attaque){
			throw new NotImplementedException ();
		}
	}
}

