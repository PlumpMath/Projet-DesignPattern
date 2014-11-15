using System;

namespace ProjetDesignPattern
{
    public abstract class JeuAbstrait
    {
        public abstract void TourDeJeu();
        public abstract void Sauvegarder();
        public abstract void RecupererInformation();
        public abstract void CalculStatistiques();
    }
}
