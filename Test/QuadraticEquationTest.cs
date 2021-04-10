using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Spesivcev;

namespace Test_Spesivcev
{
    [TestClass]
    public class QuadraticEquationTest
    {
        [TestMethod]
        [ExpectedException(typeof(TrimailovException),
        "Такое уравнение не имеет решений.")]
        public void TestMethodSolve()
        {
            QuadraticEquation myQuadraticEquation = new QuadraticEquation();
            CollectionAssert.AreEqual(new List<float>() { 2f }, myQuadraticEquation.Solve(0, 2, -4));
            CollectionAssert.AreEqual(new List<float>() { 0, -2f }, myQuadraticEquation.Solve(2, 4, 0));
            CollectionAssert.AreEqual(new List<float>() { 3, -2.5f }, myQuadraticEquation.Solve(2, -1, -15));
            myQuadraticEquation.Solve(1, -2, 2);
            SpesivcevException ex = Assert.ThrowsException<SpesivcevException>(() => myQuadraticEquation.Solve(0, 0, 5));
            Assert.AreEqual("Такое уравнение не существует.", ex.Message);

        }
    }
}
