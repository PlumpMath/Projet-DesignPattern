using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class Ennemi : PersonnageAbstrait
    {
        private enum eMode
        {
            Avance,
            Attaque
        }

        private int ptAttaque;


        public Ennemi() : base()
        {
            ComportementSeDeplacer = new ComportementSeDeplacerAPiedDT();
            ComportementCombattre = new ComportementCombattreDT();
        }

        public override void AnalyserSituation()
        {
            //si il n'a pas atteint le château -> avancer, sinon -> attaquer le château
            throw new NotImplementedException();
        }

        public override void Execution(eMode action)
        {
            //avancer ou attaquer
            if (action == eMode.Attaque)
            {
                Console.WriteLine("Ennemi " + this.Combattre());
            }
            if (action == eMode.Avance)
            {
                Console.WriteLine("Ennemi " + this.SeDeplacer());
            }
        }

        public override void MiseAJour()
        {
            throw new NotImplementedException();
        }

        
    }
}
