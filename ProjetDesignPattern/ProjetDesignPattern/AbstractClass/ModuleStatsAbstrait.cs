using System;

namespace ProjetDesignPattern
{
    public abstract class ModuleStatsAbstrait
    {
        public Simulation jeu { get; set; }

        internal void RecupererInformation()
        {
            throw new NotImplementedException();
        }
    }
}
