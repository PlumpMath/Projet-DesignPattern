using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDesignPattern.JeuSimulationTrafic
{
    public partial class IHM_Traffic : Form
    {
        Simulation simTrafic;
        public IHM_Traffic(Simulation sim)
        {
            InitializeComponent();
            simTrafic = sim;
        }

        public void changeTexteBox(string txt)
        {
            textBox.Text = txt;
        }

        private void IHM_Traffic_Load(object sender, EventArgs e)
        {

        }

        private void IHM_Traffic_FormClosing(object sender, FormClosingEventArgs e)
        {
            simTrafic.finDuJeu = true;
        }
    }
}
