using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int test = 0;

            
            while(test++ < 10){
                Console.WriteLine(string.Format("The value is {0}", test));
            }
            System.Diagnostics.Debug.Assert(test == 0);
        }
    }
}
