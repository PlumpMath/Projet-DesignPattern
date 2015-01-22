using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDesignPattern.JeuDefenceTower
{
    public class Ennemi : PersonnageAbstrait
    {
        public enum eMode
        {
            Avance,
            Attaque
        }

        public Chateau chateau;
        private int ptAttaque;
        private bool mort=false;
        public bool touché = false;
        private bool arrivéChateau = false;
        private bool zoneSuivLibre = false;

        public Ennemi(int _pv, string _nom, int _atq,ZoneAbstraite z)
        {
            PV = _pv;
            Nom = _nom;
            ptAttaque = _atq;
            comportementSeDeplacer = new ComportementSeDeplacerAPiedDT();
            comportementCombattre = new ComportementCombattreDT();
            comporterSeDefendre = new ComportementSeDefendreDT();
            Position = z;
        }

        public Ennemi(string _nom, ZoneAbstraite z)
        {
            Nom = _nom;
            Position = z;
            comportementSeDeplacer = new ComportementSeDeplacerAPiedDT();
            comportementSeDeplacer.personnage = this;
            comportementCombattre = new ComportementCombattreDT();
            comporterSeDefendre = new ComportementSeDefendreDT();
            comporterSeDefendre.personnage = this;
        }

        public void initEnnemi(Chateau c,int _pv, int _atq)
        {
            chateau = c;
            PV = _pv;
            ptAttaque = _atq;
        }

        public override void AnalyserSituation()
        {
            //est-tu mort
            if (PV == 0)
            {
                mort = true;
                ((ZoneDT)Position).enleverEnnemi(this);
            }
            //est-tu près du château
            if (((ZoneDT)Position).jeSuisArrivéAuChateau()) arrivéChateau = true;
            //a tu pris un dégât -> défini à l'evenement Onclick
            //y a t'il quun sur ta prochaine zone
            if (((ZoneDT)Position).laZoneDapresEstLibre()) zoneSuivLibre = true;
        }

        public override void Execution()
        {
            if (!mort)
            {
                //si tu t'es pris un dégât -> baisse tes points de vie
                if(touché) PV -= chateau.ptAttaque;
                //si tu est prêt du château -> attaque
                if (arrivéChateau)
                {
                    comportementCombattre.combattre(ptAttaque, (PersonnageAbstrait)chateau);
                }
                else
                {
                    //si il y a qqun sur ta prochaine zone -> defend toi
                    if (!zoneSuivLibre)
                    {
                        comporterSeDefendre.defendre(chateau.ptAttaque);
                    }
                    else
                    {
                        List<ZoneAbstraite> listeZones = comportementSeDeplacer.déplacementPossible(Position);
                        if(listeZones.Count > 0)
                            comportementSeDeplacer.deplacer(listeZones[0]);                                                                                                           
                    
                    }
                }
                
            }
        }

        public override void MiseAJour()
        {
            throw new NotImplementedException();
        }

        
    }
}

//ENNEMIS
//1. Propagation des informations générales
//2. Propagation des ordres (ne plus bouger, sans ordre….) – propagation hiérarchique
//avance ou attaque

//3. Pour chaque personnage : AnalyseSituation()     
//est-tu mort
//est-tu près du château
//a tu pris un dégât
//y a t'il quun sur ta prochaine zone

//4. Pour chaque personnage : Execution()
//si tu es mort -> sort de la zone
//si tu t'es pris un dégât -> baisse tes points de vie
//si tu est prêt du château -> attaque
//si il y a qqun sur ta prochaine zone -> defend toi

//5. Pour chaque Conflit : Médiation des conflits()
//6. Pour chaque objet : MiseAJour()
//7. RécupérerInformations() + CalculStatistique()
//si mort -> incremente nb mort
//enleve les pv du château si il en à perdu
//8. Affichage
//actualisation de l'affichage (on retire les perso mort, on recharge la position de chaque perso)

