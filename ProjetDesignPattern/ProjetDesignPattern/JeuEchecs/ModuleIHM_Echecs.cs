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
		public IHM_Echecs ihm;
		private bool init, computer;

		public ModuleIHM_Echecs(){
			init = true;
		}
		public ModuleIHM_Echecs(bool computer){
			init = true;
			this.computer = computer;
		}

		public override void afficher(){
			if (init) {
				init = false;
				ihm = new IHM_Echecs(this.jeu);
				ihm.computer = computer;
				ihm.Show();
			}
			ihm.Refresh();
		}
	}
}
