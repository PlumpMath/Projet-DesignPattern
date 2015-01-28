using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPattern.JeuDefenceTower
{
    class ModuleStat_DT : ModuleStatsAbstrait
    {
        
        public int vieChateau;
        public int nbMorts;
        public int totalDégâtsAuChâteau;
        public int totalDégâtsAuxEnnemis;
        public int nbBalles;

        public override void RecupererInformation()
        {
            nbMorts = 0;
            totalDégâtsAuxEnnemis = 0;
            foreach (PersonnageAbstrait perso in jeu.listePersonnages)
            {
                if (perso.GetType() == typeof(Chateau))
                {
                    totalDégâtsAuChâteau += ((Chateau)perso).dégatsreçus;
                    vieChateau = perso.PV;
                    nbBalles = ((Chateau)perso).nbBallesCourant;
                }
                if (perso.GetType() == typeof(Ennemi))
                {
                    if(((Ennemi)perso).mort) nbMorts += 1;
                    totalDégâtsAuxEnnemis += ((Ennemi)perso).dégatreçus;
                }
            }
        }

        public override void CalculStatistiques()
        {
  
        }
    }
}
