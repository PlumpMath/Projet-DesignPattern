using ProjetDesignPattern.AbstractClass;
using System;

namespace ProjetDesignPattern
{
    public abstract class ModuleIHMAbstrait
    {
        public Simulation jeu { get; set; }

        public abstract void afficher();
    }
}
