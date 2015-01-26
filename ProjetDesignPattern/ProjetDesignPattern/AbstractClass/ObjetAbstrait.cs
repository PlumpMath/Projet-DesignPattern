using System;

namespace ProjetDesignPattern
{
    public abstract class ObjetAbstrait
    {
        public string Nom { get; set; }
        public ZoneAbstraite Position { get; set; }


        public abstract void MiseAJour();
    }
}
