using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementSeDeplacerAPiedDT : ComportementSeDeplacerAbstrait
    {

        public override string deplacer()
        {
            return "se déplace vers l'avant";
            
        }
    }
}
