using System;

namespace ProjetDesignPattern.JeuEchecs
{
    public abstract class PieceEchec : PersonnageAbstrait
    {
        ComportementSeDeplacer comportementSeDeplacer { get; set; }
    }
}
