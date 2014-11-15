using System;

namespace ProjetDesignPattern
{
    public abstract class ObjetAbstrait
    {
        public String Nom { get; set; }
        public ZoneAbstraite Position { get; set; }


        public abstract void MiseAJour();
    }
}
