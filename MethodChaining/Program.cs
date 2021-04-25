using System;

namespace MethodChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation(5);
            float result = cal.Addition(5)
                            .Addition(5)
                            .Multiplication(3)
                            .Division(6)
                            .Subtraction(3)
                            .Result();
            Console.WriteLine("The Result: "+ result);
        }
    }
}
