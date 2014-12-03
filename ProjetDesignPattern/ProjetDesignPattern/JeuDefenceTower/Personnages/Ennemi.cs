using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class Ennemi : PersonnageAbstrait
    {
        public enum eMode
        {
            Avance,
            Attaque
        }

        private int ptAttaque;
        private PersonnageAbstrait chateau;

        public Ennemi(int _pv, string _nom, int _atq)
        {
            init(_pv,_nom);
            ptAttaque = _atq;
            ComportementSeDeplacer = new ComportementSeDeplacerAPiedDT();
            ComportementCombattre = new ComportementCombattreDT();
        }

        public override void AnalyserSituation()
        {
            //si il n'a pas atteint le château -> avancer, sinon -> attaquer le château
            throw new NotImplementedException();
        }

        public override void Execution()
        {
            //avancer ou attaquer
            /*if (action == eMode.Attaque)
            {
                Console.WriteLine("Ennemi " + Nom + this.Combattre(ptAttaque, chateau));
            }
            if (action == eMode.Avance)
            {
                Console.WriteLine("Ennemi " + Nom + this.SeDeplacer());
            }*/
        }

        public override void MiseAJour()
        {
            throw new NotImplementedException();
        }

        
    }
}
