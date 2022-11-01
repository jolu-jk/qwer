using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void TestMethod1() 
        {
            int a = 2;
            int b = 3;
            int c = 5;
            int expected = 10;

            Geometry g = new Geometry();
            int actual = g.Sum(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int a = -3;
            int b = 42;
            int c = 6;
            int expected = 45;

            Geometry g = new Geometry();
            int actual = g.Sum(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod3()
        {
            int a = 9;
            int b = 8;
            int c = 100;
            int expected = 116;

            Geometry g = new Geometry();
            int actual = g.Sum(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod4()
        {
            int a = 0;
            int b = 8;
            int c = -8;
            int expected = 0;

            Geometry g = new Geometry();
            int actual = g.Sum(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
