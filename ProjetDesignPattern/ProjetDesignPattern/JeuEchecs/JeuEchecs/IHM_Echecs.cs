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

		public IHM_Echecs(Simulation jeu)
		{
			InitializeComponent(jeu);
		}

		private void imageClick(object sender, EventArgs e){

		}
	}
}
