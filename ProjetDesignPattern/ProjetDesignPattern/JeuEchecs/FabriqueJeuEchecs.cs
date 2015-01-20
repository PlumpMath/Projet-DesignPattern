using System;

namespace ProjetDesignPattern.JeuEchecs
{
    class FabriqueJeuEchecs : FabriqueAbstraite
    {
		public override PersonnageAbstrait CreerPersonnage(string _type, string _nom,string _pv, string _etat, string zonePresent, SujetObserveAbstrait EtatMajor)
        {
			PersonnageAbstrait personnage;

			//Definition du type du personnage pour la simulation echec
			switch (_type) {
			case "Pion":
				personnage = new JeuEchecs.Pion ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementPion ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Tour":
				personnage = new JeuEchecs.Tour ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementTour ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Fou":
				personnage = new JeuEchecs.Fou ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementFou ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Reine":
				personnage = new JeuEchecs.Reine ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementReine ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Cavalier":
				personnage = new JeuEchecs.Cavalier ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementCavalier ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			case "Roi":
				personnage = new JeuEchecs.Roi ();
				personnage.comportementCombattre = new JeuEchecs.AttaqueBasique ();
				personnage.comportementSeDeplacer = new JeuEchecs.DeplacementRoi ();
				personnage.comporterSeDefendre = new JeuEchecs.AucuneDefense ();
				break;
			default:
				personnage = null;
				break;
			}
			//Set des autres attributs d'un personnage
			if (null != personnage) {
				personnage.Nom = _nom;
				personnage.PV = Convert.ToInt32 (_pv);
				//personnage.etatCourant = _etat;
			}

			//FAIRE UNE BOUCLE SUR LA LISTE DES ZONNE POUR DEFINIR LA ZONNE 
			//personnage.zonne

			return personnage;
			//switch
			//PieceEchec personnageEchec = new JeuEchecs.PieceEchec ();

        }


        public override ZoneAbstraite CreerZone()
        {
            throw new NotImplementedException();
        }

        public override AccesAbstrait CreerAcces()
        {
            throw new NotImplementedException();
        }
    }
}
