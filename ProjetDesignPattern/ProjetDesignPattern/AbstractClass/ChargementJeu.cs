using System;
using System.Windows.Forms;

namespace ProjetDesignPattern.AbstractClass
{
    public class ChargementJeu
    {
     
        public ChargementJeu ()
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\" ;
            openFileDialog1.Filter = "xml files (*.xml)|*.xml" ;
            openFileDialog1.FilterIndex = 2 ;
            openFileDialog1.RestoreDirectory = true ;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {   
                    System.IO.StreamReader sr = new
                        System.IO.StreamReader(openFileDialog1.FileName);
                    MessageBox.Show(sr.ReadToEnd());
                    sr.Close();  

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: Fichier non trouvé. " + ex.Message);
                }

            }
           
        }
        
    }
}
