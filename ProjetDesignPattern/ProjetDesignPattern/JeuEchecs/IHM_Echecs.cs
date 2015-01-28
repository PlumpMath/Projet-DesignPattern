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
		public IHM_Echecs(Simulation jeu)
		{
			InitializeComponent(jeu);
			caseSelect = null;
		}

		private void imageClick(object sender, EventArgs e){
			Location current = new Location(((PictureBox)sender).Name);
			Console.WriteLine (current.x + "," + current.y);
			if (caseSelect != null) {
				if (caseSelect.Equals (current)) {
					unSelectCase (current);
				}
			} else {
				selectCase (current);
			}

		}

		private void unSelectCase(Location _case){
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
	}
}
