namespace ConsoleApp1
{
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {

            Console.WriteLine("Constructor is calling");
        }
        static void Main(string[] args)
        {
            ExplicitConstructor obj1 = new ExplicitConstructor();
            ExplicitConstructor obj2 = new ExplicitConstructor();
            ExplicitConstructor obj3 = new ExplicitConstructor();
            Console.ReadLine();

        }
    }
}
