using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementSeDeplacerAPiedDT : ComportementSeDeplacerAbstrait
    {

        public override string Deplacer()
        {
            return "se déplace vers l'avant";
        }
    }
}
