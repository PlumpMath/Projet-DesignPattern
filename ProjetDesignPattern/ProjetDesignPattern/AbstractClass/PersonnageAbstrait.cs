using System;

namespace ProjetDesignPattern
{
     public abstract class PersonnageAbstrait : ObservateurAbstrait
    {
		public int idPersonnage { get; set; }
        public String Nom { get; set; }
        public int PV { get; set; }

        public SujetObserveAbstrait EtatMajor { get; set; }
        public ZoneAbstraite Position { get; set; }
        public EtatAbstrait etatCourant { get; set; }
        public ComportementCombattreAbstrait comportementCombattre { get; set; }
        public ComportementSeDeplacerAbstrait comportementSeDeplacer { get; set; }
        public ComporterSeDefendreAbstrait comporterSeDefendre { get; set; }

        public abstract void AnalyserSituation();
        public abstract void Execution();

        public void Combattre(int degat, PersonnageAbstrait cible)
        {
			if (comportementCombattre != null) {
				Console.WriteLine (this.Nom + " attaque " + cible.Nom);
				comportementCombattre.combattre (degat, cible);
			}
        }

        public void SeDeplacer(ZoneAbstraite zone)
        {
            if (comportementSeDeplacer != null){
                comportementSeDeplacer.deplacer(zone);
			}
        }

        public string SeDefendre(int attaque)
        {
            if (comporterSeDefendre != null)
                comporterSeDefendre.defendre(attaque);
            return "Je ne me défend pas";
        }

        public void init (int _pv, string _nom)
        {
            comportementCombattre = null;
            comportementSeDeplacer = null;
            comporterSeDefendre = null;
            Nom = _nom;
            PV = _pv;
        }
    }
}
