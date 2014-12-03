using System;

namespace ProjetDesignPattern
{
    public abstract class PersonnageAbstrait : ObservateurAbstrait
    {
        public String Nom { get; set; }
        public int PV { get; set; }

        public SujetObserveAbstrait EtatMajor { get; set; }
        public ZoneAbstraite Position { get; set; }
        public EtatAbstrait etatCourant { get; set; }
        public ComportementCombattreAbstrait ComportementCombattre { get; set; }
        public ComportementSeDeplacerAbstrait ComportementSeDeplacer { get; set; }
        public ComporterSeDefendreAbstrait ComporterSeDefendre { get; set; }

        public abstract void AnalyserSituation();
        public abstract void Execution();


    }
}
