using System;

namespace ProjetDesignPattern
{
    public abstract class FabriqueAbstraite
    {


		public abstract PersonnageAbstrait CreerPersonnage(string _type, string _nom,string _pv, string _etat, string zonePresent, SujetObserveAbstrait EtatMajor);

        public abstract ZoneAbstraite CreerZone();

        public abstract AccesAbstrait CreerAcces();
    }
}
