using System;
namespace ProjetDesignPattern.JeuDefenceTower
{
    abstract class EtatAbstraitDT : EtatAbstrait
    {
        public abstract void Tirer();
        public abstract void PlusDeMunitions();
        public abstract void FinRechargement();
        public abstract void AttaqueSpecialePlusDégat();
        public abstract void AttaqueSpecialePlusDeMunitions();
    }
}
