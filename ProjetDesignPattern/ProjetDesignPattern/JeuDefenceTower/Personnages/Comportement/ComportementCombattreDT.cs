using System;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class ComportementCombattreDT : ComportementCombattreAbstrait
    {

        public override void combattre(int degat, PersonnageAbstrait chateau)
        {
            //TODO Mettre dans les logs
            //"inflige " + degat + " dégats à " + cible.Nom;
            ((Chateau)chateau).dégatsreçus += degat;
        }
    }
}
