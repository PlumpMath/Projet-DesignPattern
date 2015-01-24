using System;

namespace ProjetDesignPattern
{
    public abstract class ModuleStatsAbstrait
    {
        public Simulation jeu { get; set; }
        public abstract void RecupererInformation();
        public abstract void CalculStatistiques();
    }
}
