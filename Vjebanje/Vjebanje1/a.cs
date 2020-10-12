using System;

namespace Vjebanje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            Dog rex;
            rex = new Dog();
            Console.WriteLine(rex.Bark());
            rex.SetAge(11);
            Console.WriteLine(rex.GetAge());

         
        }
    }
}
