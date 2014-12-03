using System;

namespace ProjetDesignPattern
{
	public abstract class ComporterSeDefendreAbstrait
	{
		public PersonnageAbstrait personnage { get; set;}

        public abstract void Defendre(int attaque);
	}
}

