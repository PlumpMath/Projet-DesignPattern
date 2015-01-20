using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class FabriqueJeuDT : FabriqueAbstraite
    {
		public override PersonnageAbstrait CreerPersonnage(string _type, string _nom,string _pv, string _etat, string zonePresent, SujetObserveAbstrait EtatMajor)
        {
            throw new NotImplementedException();
        }

        public override ZoneAbstraite CreerZone()
        {
            throw new NotImplementedException();
        }

        public override AccesAbstrait CreerAcces()
        {
            throw new NotImplementedException();
        }

    }
}
