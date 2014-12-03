using System;

namespace ProjetDesignPattern.JeuEchecs
{
	public class Case : ZoneAbstraite
	{
		public Case(){

		}

		public void setPièce(PieceEchec p){
			// TODO rajouter la pièce à la liste 
		}

		public PieceEchec getPièce(){
			// TODO retourner la pièce, sinon null
            return null;
		}

		public bool possèdeUnePièce (){
			// TODO indique si la case possède une pièce
            return false;
		}
	}
}

