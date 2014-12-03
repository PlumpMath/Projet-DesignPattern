using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementCombattreDT : ComportementCombattreAbstrait
    {

        public override string Combattre(int degat, PersonnageAbstrait cibles)
        {
            return "tape";
        }
    }
}
