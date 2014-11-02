using System;

namespace AbstractClass.Decorateur
{
    //-----------------------------------------------------------------------------
    internal abstract class ComposantAbstrait
    {
        public abstract void Operation();
    }


    //-----------------------------------------------------------------------------
    internal class ComposantConcret : ComposantAbstrait
    {
        public override void Operation()
        {
            Console.WriteLine("ComponentConcret.Operation()");
        }
    }


    //-----------------------------------------------------------------------------
    internal abstract class DecorateurAbstrait : ComposantAbstrait
    {
        protected ComposantAbstrait Composant;

        public void SetComposant(ComposantAbstrait composantImbriqué)
        {
            Composant = composantImbriqué;
        }

        public override void Operation()
        {
            if (Composant != null)
            {
                Composant.Operation();
            }
        }
    }


    //-----------------------------------------------------------------------------
    internal class DecorateurConcretA : DecorateurAbstrait
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }


    //-----------------------------------------------------------------------------
    internal class DecorateurConcretB : DecorateurAbstrait
    {
        public override void Operation()
        {
            base.Operation();
            ajouteComportement();

            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        private void ajouteComportement()
        {
        }
    }
}