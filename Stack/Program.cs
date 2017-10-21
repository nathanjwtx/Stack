using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            var finished = false;
            while (finished == false)
            {
                Console.WriteLine("(A)dd to stack, (R)emove item, or (E)mpty the stack?");
                var response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "A":
                        Console.WriteLine("Enter object to push: ");
                        stack.Push(Console.ReadLine());
                        break;
                    case "R":
                        Console.WriteLine(stack.Pop());
                        break;
                    case "E":
                        stack.Clear();
                        break;
                    default:
                        finished = true;
                        break;
                }
            }
        }
    }
}