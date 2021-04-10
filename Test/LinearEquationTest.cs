using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Spesivcev;

namespace Test_Spesivcev
{

    [TestClass]
    public class LinearEquationTest
    {
        [TestMethod]
        [ExpectedException(typeof(SpesivcevException),
        "Такое уравнение не существует.")]

        public void TestMethodSolve()
        {
            LinearEquation myLinearEquation = new LinearEquation();
            CollectionAssert.AreEqual(new List<float>() { 2f }, myLinearEquation.Solve(2, -4, 0));
            CollectionAssert.AreEqual(new List<float>() { -0.625f }, myLinearEquation.Solve(8, 5, 0));
            myLinearEquation.Solve(0, 1, 0);
        }
    }
}
