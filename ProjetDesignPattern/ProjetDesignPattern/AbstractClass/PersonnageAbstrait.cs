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

        public string Combattre()
        {
            if (ComportementCombattre != null)
                return ComportementCombattre.Combattre();
            return "Je ne combat pas";
        }

        public string SeDeplacer()
        {
            if (ComportementSeDeplacer != null)
                return ComportementSeDeplacer.Deplacer();
            return "Je ne bouge pas";
        }

        public string SeDefendre()
        {
            if (ComporterSeDefendre != null)
                return ComporterSeDefendre.Defendre();
            return "Je ne me défend pas";
        }

        public void init (int _pv, string _nom)
        {
            ComportementCombattre = null;
            ComportementSeDeplacer = null;
            ComporterSeDefendre = null;
            Nom = _nom;
            PV = _pv;

        }


    }
}
