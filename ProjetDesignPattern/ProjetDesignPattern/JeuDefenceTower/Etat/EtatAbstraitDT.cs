using System;
namespace ProjetDesignPattern.JeuDefenceTower
{
    public abstract class EtatAbstraitDT : EtatAbstrait
    {
        
        public Chateau chateau;

        public EtatAbstraitDT(Chateau lechateau)
        {
            chateau = lechateau;
        }

        public abstract int Tirer();
        public abstract int AttaqueSpecialePlusDégat();
    }
}
