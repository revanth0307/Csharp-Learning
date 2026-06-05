using System;

namespace ConsoleApp1
{
    public class Class1
    {
        private void Test1() 
        {
            Console.WriteLine("Private method");     
        }
        internal void Test2()
        {
            Console.WriteLine("internal method");
        }

        protected void Test3()
        {
            Console.WriteLine("protected method");
        }

        protected internal void Test4()
        {
            Console.WriteLine(" protectedd internal method");
        }

        public void Test5()
        {
            Console.WriteLine("public method");
        }

       public static void Main(string[] args)
        {
            Class1 c= new Class1();
            c.Test1();
            c.Test2();
            c.Test3();
            c.Test4();
            c.Test5();
        }
    }
    
}
