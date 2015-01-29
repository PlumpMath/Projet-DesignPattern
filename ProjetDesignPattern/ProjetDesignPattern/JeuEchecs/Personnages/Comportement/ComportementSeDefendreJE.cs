using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementSeDefendreJE:ComporterSeDefendreAbstrait
	{
		public int defense { get; set;}

		public override void defendre(int attaque){
			this.personnage.PV -= attaque;
			if (this.personnage.PV == 0) {
				Console.WriteLine (this.personnage.Nom + " meurt");
				this.personnage.SeDeplacer (null);
				//TODO set etat mort
			}
		}
	}
}

