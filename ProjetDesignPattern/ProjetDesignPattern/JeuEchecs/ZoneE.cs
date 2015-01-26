using System;
namespace ProjetDesignPattern.JeuEchecs
{
	class ZoneE : ZoneAbstraite
	{
	
		public ZoneE (){
			this.listePersonnages = new System.Collections.Generic.List<PersonnageAbstrait>();
			this.listeAccess = new System.Collections.Generic.List<AccesAbstrait>();
			this.listeObjets = new System.Collections.Generic.List<ObjetAbstrait>();
		}
	}

}