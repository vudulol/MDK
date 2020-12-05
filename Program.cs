using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            Quadratic myQuadratic = new Quadratic();

            float a, b, c;
            Console.WriteLine("Введите 3 параметра a, b и с");
            Console.Write("a = ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToSingle(Console.ReadLine());
    try
            {
                MyLog.Log("Корни уравнения: " + String.Join(" ", myQuadratic.Solve(a, b, c)));
            }
    catch (SpesivcevException e)
            {
                MyLog.Log(e.Message);
            }
            MyLog.Write();
    }
}
