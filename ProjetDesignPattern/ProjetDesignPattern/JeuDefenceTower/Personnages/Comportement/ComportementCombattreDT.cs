using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementCombattreDT : ComportementCombattreAbstrait
    {

        public override string combattre(int degat, PersonnageAbstrait cible)
        {
            return "inflige " + degat + " dégats à " + cible.Nom;
        }
    }
}
