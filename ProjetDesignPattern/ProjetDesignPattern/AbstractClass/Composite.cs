using System;
using System.Collections.Generic;

namespace AbstractClass.Composite
{
    //-----------------------------------------------------------------------------
    internal abstract class ComposantAbstrait
    {
        protected string nom;

        public ComposantAbstrait(string unNom)
        {
            nom = unNom;
        }

        public abstract void Ajoute(ComposantAbstrait c);
        public abstract void Retire(ComposantAbstrait c);
        public abstract void AffichageRecursif(int profondeur);
    }


    //-----------------------------------------------------------------------------
    internal class Composite : ComposantAbstrait
    {
        private readonly List<ComposantAbstrait> enfants = new List<ComposantAbstrait>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Ajoute(ComposantAbstrait component)
        {
            enfants.Add(component);
        }

        public override void Retire(ComposantAbstrait component)
        {
            enfants.Remove(component);
        }

        public override void AffichageRecursif(int profondeur)
        {
            Console.WriteLine(new String('-', profondeur) + nom);

            // Affiche Récusivement les enfants composants
            foreach (ComposantAbstrait component in enfants)
            {
                component.AffichageRecursif(profondeur + 2);
            }
        }
    }


    //-----------------------------------------------------------------------------
    internal class Feuille : ComposantAbstrait
    {
        public Feuille(string name)
            : base(name)
        {
        }

        public override void Ajoute(ComposantAbstrait c)
        {
            Console.WriteLine("Impossible d'ajouter à une feuille");
        }

        public override void Retire(ComposantAbstrait c)
        {
            Console.WriteLine("Impossible de retirer à une feuille");
        }

        public override void AffichageRecursif(int profondeur)
        {
            Console.WriteLine(new String('-', profondeur) + nom);
        }
    }
}