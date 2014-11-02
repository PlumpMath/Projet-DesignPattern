namespace AbstractClass.Fabrication
{
    //-----------------------------------------------------------------------------
    internal abstract class ProduitAbstrait
    {
    }

    //-----------------------------------------------------------------------------
    internal class ProduitConcretA : ProduitAbstrait
    {
    }

    //-----------------------------------------------------------------------------
    internal class ProduitConcretB : ProduitAbstrait
    {
    }

    //-----------------------------------------------------------------------------
    internal abstract class FabriqueAbstraite
    {
        public abstract ProduitAbstrait CreerProduit();
    }

    //-----------------------------------------------------------------------------
    internal class FabriqueConcreteA : FabriqueAbstraite
    {
        public override ProduitAbstrait CreerProduit()
        {
            return new ProduitConcretA();
        }
    }

    //-----------------------------------------------------------------------------
    internal class FabriqueConcreteB : FabriqueAbstraite
    {
        public override ProduitAbstrait CreerProduit()
        {
            return new ProduitConcretB();
        }
    }
}