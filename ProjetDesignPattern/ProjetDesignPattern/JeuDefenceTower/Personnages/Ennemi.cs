using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class Ennemi : PersonnageAbstrait
    {

        public Ennemi() : base()
        {
        }

        public override void AnalyserSituation()
        {
            //si il n'a pas atteint le château -> avancer, sinon -> attaquer le château
            throw new NotImplementedException();
        }

        public override void Execution()
        {
            //avancer ou attaquer
            throw new NotImplementedException();
        }

        public override void MiseAJour()
        {
            throw new NotImplementedException();
        }

        
    }
}
