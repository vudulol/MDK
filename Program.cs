using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            Quadratic myQuadratic = new Quadratic();
    try
            {
                MyLog.Log("Корни уравнения: " + String.Join(" ", myQuadratic.Solve(1, -2, -3)));
            }
    catch (Exception e)
            {
                MyLog.Log(e.Message);
            }
            MyLog.Write();
    }
}
