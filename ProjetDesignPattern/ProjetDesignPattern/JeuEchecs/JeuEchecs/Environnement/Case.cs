using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public class Case : ZoneAbstraite
	{
		public Case(){
			this.listeObjets = new System.Collections.Generic.List<ObjetAbstrait> ();
			this.listePersonnages = new System.Collections.Generic.List<PersonnageAbstrait> ();
			this.zonesAdjacentes = new System.Collections.Generic.Dictionary<int, AccesAbstrait> ();
		}
	}
}

