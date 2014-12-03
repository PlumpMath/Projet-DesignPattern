using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public abstract class AccesCaseAbstraite
	{
		Case départ { get; set;}
		Case arrivé { get; set;}
		bool accès { get; set;}
	}
}

