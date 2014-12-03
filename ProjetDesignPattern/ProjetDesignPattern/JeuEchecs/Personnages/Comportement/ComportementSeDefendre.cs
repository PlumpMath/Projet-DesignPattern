using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class ComportementSeDefendre:ComporterSeDefendreAbstrait
	{
		public int defense { get; set;}

		public abstract int seDefendre (int degat);
	}
}

