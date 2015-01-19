using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementCombattreDT : ComportementCombattreAbstrait
    {

        public override void combattre(int degat, PersonnageAbstrait cible)
        {
            //TODO Mettre dans les logs
            //"inflige " + degat + " dégats à " + cible.Nom;
        }
    }
}
