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

		public IHM_Echecs(Simulation jeu)
		{
			this.jeu = jeu;
			InitializeComponent(jeu);
			caseSelect = null;
			depPossible = null;
		}

		private void imageClick(object sender, EventArgs e){
			Location current = new Location(((PictureBox)sender).Name);
			Console.WriteLine (current.name);
			if (caseSelect != null) {
				Console.WriteLine ("a0 " + caseSelect.name);
				if (caseSelect.Equals (current)) {
					Console.WriteLine ("Unselect");
					unSelectCase (current);
				} else if (depPossible != null) {
					for (int i = 0; i < depPossible.Count; i++) {
						if (current.name == depPossible [i].name) {
							Console.WriteLine ("Déplacement");
							break;
						}
					}
				}
			} else {
				int i = caseContainsPiece (current);
				if (i != -1) {
					selectCase (current);
					colorizeDeplacementPossible (i);
				}
			}

		}

		private void unSelectCase(Location _case){
			Console.WriteLine ("p0");
			if (depPossible != null) {
				Console.WriteLine ("p1 " + depPossible.Count);
				for (int j = 0 ; j < depPossible.Count ; j++) {
					for (int i = 0 ; i < cases.Length ; i++) {
						if (cases [i].Name == depPossible [j].name) {
							colorizeCase (i, depPossible [j]);
							break;
						}
					}
				}
				depPossible = null;
			}
			for (int i = 0; i < cases.Length; i++) {
				if (cases [i].Name == _case.name) {
					caseSelect = null;
					colorizeCase (i, _case);
					break;
				}
			}
		}

		private void selectCase(Location _case){
			for (int i = 0; i < cases.Length; i++) {
				if (cases [i].Name == _case.name) {
					caseSelect = _case;
					cases [i].BackColor = System.Drawing.Color.Green;
					break;
				}
			}
		}

		private void selectCaseDep(Location _case){
			for (int i = 0; i < cases.Length; i++) {
				if (cases [i].Name == _case.name) {
					cases [i].BackColor = System.Drawing.Color.Blue;
					break;
				}
			}
		}

		private int caseContainsPiece(Location _case){
			for (int i = 0; i < jeu.listeZones.Count; i++) {
				if (jeu.listeZones [i].positionX == _case.x &&
					jeu.listeZones [i].positionY == _case.y ) {
					if(jeu.listeZones[i].listePersonnages.Count > 0)
					return i;
					break;
				}
			}
			return -1;
		}

		private void colorizeCase(int i, Location l){
			if (l.x % 2 == 0) {
				if (l.y % 2 == 0) {
					cases [i].BackColor = System.Drawing.Color.DarkGray;
				} else {
					cases [i].BackColor = System.Drawing.Color.WhiteSmoke;
				}
			} else {
				if (l.y % 2 == 0) {
					cases [i].BackColor = System.Drawing.Color.WhiteSmoke;
				} else {
					cases [i].BackColor = System.Drawing.Color.DarkGray;
				}
			}
		}
		private void colorizeDeplacementPossible(int index){
			List<ZoneAbstraite> list = jeu.listeZones [index].listePersonnages [0].comportementSeDeplacer.déplacementPossible (jeu.listeZones [index]);
			if(list.Count > 0){
				depPossible = new List<Location>();
				for(int i = 0 ; i < list.Count ; i++){
					depPossible.Add(new Location(list[i].positionX, list[i].positionY));
					selectCaseDep (depPossible [0]);
				}
			}
		}
	}
}
