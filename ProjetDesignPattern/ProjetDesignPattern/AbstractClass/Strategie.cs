using System;

namespace AbstractClass.Strategie
{
    //-----------------------------------------------------------------------------
    internal abstract class StrategieAbstraite
    {
        public abstract void Operation();
    }

    //-----------------------------------------------------------------------------
    internal class StrategieConcreteA : StrategieAbstraite
    {
        public override void Operation()
        {
            Console.WriteLine("Appel StrategieConcreteA.Operation()");
        }
    }

    //-----------------------------------------------------------------------------
    internal class StrategieConcreteB : StrategieAbstraite
    {
        public override void Operation()
        {
            Console.WriteLine("Appel StrategieConcreteB.Operation()");
        }
    }

    //-----------------------------------------------------------------------------
    internal class StrategieConcreteC : StrategieAbstraite
    {
        public override void Operation()
        {
            Console.WriteLine("Appel StrategieConcreteC.Operation()");
        }
    }

    
    //-----------------------------------------------------------------------------
    internal class Contexte
    {
        private StrategieAbstraite stategieCourante;

        public Contexte(StrategieAbstraite uneStrategie)
        {
            stategieCourante = uneStrategie;
        }


        internal void ModifieStrategie(StrategieAbstraite uneStrategie)
        {
            stategieCourante = uneStrategie;
        }

        internal void Execute()
        {
            stategieCourante.Operation();
        }
    }
}