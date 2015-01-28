using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuEchecs
{
	public class ModuleIHM_Echecs : ModuleIHMAbstrait
	{
		IHM_Echecs ihm;

		public ModuleIHM_Echecs(){
		}

		public override void afficher(){
			ihm = new IHM_Echecs(this.jeu);
			ihm.Show();
			ihm.Refresh();
		}
	}
}

