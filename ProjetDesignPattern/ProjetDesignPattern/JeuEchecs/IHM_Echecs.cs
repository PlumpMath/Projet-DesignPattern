using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuEchecs
{
	public partial class IHM_Echecs : Form
	{
		private Location caseSelect;
		private List<Location> depPossible;
		private Simulation jeu;
		private bool tour;
		public bool computer{ get; set;}

		public IHM_Echecs(Simulation jeu)
		{
			this.jeu = jeu;
			InitializeComponent(jeu);
			caseSelect = null;
			depPossible = null;
			tour = true;
			computer = false;
		}

		public void afficher(){

		}

		private void fin(object sender, EventArgs e){
			jeu.finDuJeu = true;
		}

		private void imageClick(object sender, EventArgs e){
			Location current = new Location(((PictureBox)sender).Name);
			Console.WriteLine ("Case click : " + current.name);
			if (caseSelect != null) {
				Console.WriteLine ("Start unselect case");
				if (caseSelect.Equals (current)) {
					Console.WriteLine ("Start unselect");
					unSelectCase (current);
				} else if (depPossible != null) {
					for (int i = 0; i < depPossible.Count; i++) {
						if (current.name == depPossible [i].name) {
							Console.WriteLine ("Start Déplacement");
							déplacement (caseSelect, current, false);
							break;
						}
					}
				}
			} else {
				int i = caseContainsPiece (current);
				if (i != -1) {
					Console.WriteLine ("Start select case");
					selectCase (current);
					colorizeDeplacementPossible (i);
				}
			}

		}
		private void unSelectCase(Location _case){
			if (depPossible != null) {
				for (int j = 0 ; j < depPossible.Count ; j++) {
					for (int i = 0 ; i < cases.Length ; i++) {
						if (cases [i].Name == depPossible [j].name) {
							resetCaseColor (i, depPossible [j]);
							break;
						}
					}
				}
				depPossible = null;
			}
			for (int i = 0; i < cases.Length; i++) {
				if (cases [i].Name == _case.name) {
					caseSelect = null;
					resetCaseColor (i, _case);
					break;
				}
			}
		}

		private void selectCase(Location _case){
			for (int i = 0; i < cases.Length; i++) {
				if (cases [i].Name == _case.name) {
					caseSelect = _case;
					colorCase (i, System.Drawing.Color.Green);
					break;
				}
			}
		}

		private int caseContainsPiece(Location _case){
			int index = -1;
			for (int i = 0; i < jeu.listeZones.Count; i++) {
				if (jeu.listeZones [i].positionX == _case.x &&
				    jeu.listeZones [i].positionY == _case.y ) {
					if(jeu.listeZones[i].listePersonnages.Count > 0)
						index = i;
					break;
				}
			}
			if (index != -1) {
				char c = jeu.listeZones [index].listePersonnages [0].Nom [0];
				if (c == 'W' && !tour || c == 'B' && tour)
					index = -1;
			}
			return index;
		}

		private void colorizeDeplacementPossible(int index){
			List<ZoneAbstraite> list = jeu.listeZones [index].listePersonnages [0].comportementSeDeplacer.déplacementPossible (jeu.listeZones [index]);
			if(list.Count > 0){
				depPossible = new List<Location>();
				for(int i = 0 ; i < list.Count ; i++){
					Location l = new Location (list [i].positionX, list [i].positionY);
					if(!(list[i].listePersonnages.Count > 0 && list[i].listePersonnages[0].Nom[1] == 'K')){ 
						depPossible.Add(l);
						colorCase (l, System.Drawing.Color.Blue);
					}
				}
			}
		}

		private void déplacement(Location départ, Location arrivé, bool cmp){
			int indexDépart = -1, indexArrivé = -1;
			for (int i = 0; i < jeu.listeZones.Count ; i++) {
				if (jeu.listeZones[i].positionX == départ.x &&
				    jeu.listeZones[i].positionY == départ.y ) {
					indexDépart = i;
				} else if (jeu.listeZones[i].positionX == arrivé.x &&
				           jeu.listeZones[i].positionY == arrivé.y) {
					indexArrivé = i;
				}
				if (indexArrivé != -1 && indexDépart != -1) {
					break;
				}
			}
			if (jeu.listeZones [indexArrivé].listePersonnages.Count > 0) {
				Console.WriteLine ("Start attaque");
				jeu.listeZones [indexDépart].listePersonnages [0].Combattre (0, 
				                                                             jeu.listeZones [indexArrivé].listePersonnages [0]
				                                                             );
			} 
			setCaseImage (départ, null);
			setCaseImage (arrivé, jeu.listeZones [indexDépart].listePersonnages [0].Nom);
			jeu.listeZones [indexDépart].listePersonnages [0].SeDeplacer (jeu.listeZones [indexArrivé]);

			Console.WriteLine ("Déplacement " + jeu.listeZones [indexArrivé].listePersonnages [0].Nom + " vers " + arrivé.name);

			if (!cmp)
				unSelectCase (caseSelect);
			changementTour ();

		}
		private bool isEchec(string name){
			int nbr = 0;
			ZoneAbstraite caseKing = null;
			for (int i = 0; i < jeu.listePersonnages.Count; i++) {
				if (jeu.listePersonnages [i].Nom == name) {
					caseKing = jeu.listePersonnages [i].Position;
					nbr = jeu.listePersonnages [i].comportementSeDeplacer.déplacementPossible (caseKing).Count;
				}
			}
			ZoneAbstraite tmp;
			List<ZoneAbstraite> list;
			bool echec = false;
			for (int i = 0; i < jeu.listePersonnages.Count; i++) {
				if (jeu.listePersonnages [i].Nom != name && jeu.listePersonnages[i].Nom[0] != name[0]) {
					tmp = jeu.listePersonnages [i].Position;
					if (tmp != null) {
						list = jeu.listePersonnages [i].comportementSeDeplacer.déplacementPossible (tmp);
						for (int j = 0; j < list.Count; j++) {
							if (list [j].positionX == caseKing.positionX && list [j].positionY == caseKing.positionY) {
								nbr--;
								echec = true;
								break;
							}
						}
						if (nbr == 0) {
							return echec;
						}
					}
				}
			}
			return echec;
		}

		private void changementTour(){
			tour = !tour;
			colorizeKing ("WK", isEchec ("WK"));
			colorizeKing ("BK", isEchec ("BK"));
			if (tour) {
				this.indicateur.Text = "Tour blanc";
			} else {
				this.indicateur.Text = "Tour noir";
				if (computer) {
					computerTour ();
				}
			}

		}

		private void colorizeKing(string name, bool echec){
			for (int i = 0; i < jeu.listePersonnages.Count; i++) {
				if (jeu.listePersonnages [i].Nom == name) {
					Location l = new Location(jeu.listePersonnages [i].Position.positionX,jeu.listePersonnages [i].Position.positionY);
					if(echec)
						colorCase(l, System.Drawing.Color.Red);
					else 
						for (int j = 0 ; j < cases.Length ; j++) 
							if (cases [j].Name == l.name) 
								resetCaseColor (j, l);
				}
			}
		}

		private void computerTour(){
			Random rdm = new Random ();
			List<PersonnageAbstrait> pieceJouable = new List<PersonnageAbstrait> ();
			List<List<ZoneAbstraite>> dep = new List<List<ZoneAbstraite>> ();
			for (int i = 0; i < jeu.listePersonnages.Count; i++) {
				if (jeu.listePersonnages [i].Nom [0] == 'B') {
					ZoneAbstraite z = jeu.listePersonnages [i].Position;
					if (z != null) {
						List<ZoneAbstraite> tmp = jeu.listePersonnages [i].comportementSeDeplacer.déplacementPossible (z);
						if (tmp.Count > 0) {
							pieceJouable.Add (jeu.listePersonnages [i]);
							dep.Add (tmp);
						}
					}
				}
			}
			int p = rdm.Next(pieceJouable.Count);
			int d = rdm.Next (dep [p].Count);
			Location départ = new Location (pieceJouable[p].Position.positionX, pieceJouable[p].Position.positionY);
			Location arrivé = new Location (dep[p][d].positionX, dep[p][d].positionY);
			déplacement (départ, arrivé, true);
		}

	}
}