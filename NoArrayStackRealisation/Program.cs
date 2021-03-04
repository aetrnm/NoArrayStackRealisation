using System;

namespace NoArrayStackRealisation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Stackkk<int?> intStack = new Stackkk<int?>();

            int? a = 10;
            
            intStack.Push(a);
            
            Console.WriteLine(intStack.Peek());
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.IsEmpty());*/
            
            Stackkk<int> intStack = new Stackkk<int>();
            
            intStack.Push(10);
            intStack.Push(9);
            intStack.Push(8);
            intStack.Push(7);
            intStack.Push(6);
            intStack.Push(5);

            Console.WriteLine("FOREACH OUTPUT:");
            foreach (var x in intStack)
            {
                Console.WriteLine(x);
            }
            
            Console.WriteLine("TOSTRING OUTPUT:");
            Console.WriteLine(intStack);
            
            /*for (long i = 0; i < 1000000000; i++)
            {
                intStack.Push(3);
            }*/
        }
    }
}