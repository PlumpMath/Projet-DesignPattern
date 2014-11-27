using System;

namespace ProjetDesignPattern.JeuEchecs
{
    public abstract class PieceEchec : PersonnageAbstrait
    {
        ComportementSeDeplacer comportementSeDeplacer { get; set; }
		ComportementAttaquer comportementAttaquer{ get; set; }
		int equipe { get; set; }

    }
}
