namespace AbstractClass.Singleton
{
    internal class Singleton
    {
        private static Singleton instance;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}