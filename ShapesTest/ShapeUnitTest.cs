using NUnit.Framework;
using Shapes;
using System;

namespace ShapesTest
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void Area_0_NoArguments()
        {
            Triangle triangle = new Triangle();
            Assert.Zero(triangle.Area);
        }
        [Test]
        public void Area_MoreThan0_ShortSides()
        {
            Triangle triangle = new Triangle(10.5,2,3);
            Assert.Positive(triangle.Area);
        }
        [Test]
        public void Area_24_PositiveArguments()
        {
            Triangle triangle = new Triangle(10, 6, 8);
            Assert.AreEqual(24,triangle.Area);
        }
        [Test]
        public void new_ExceptionThrown_NotPositiveValues()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));

        }

        [Test]
        public void IsRight_true_RightTriangle()
        {
            Triangle triangle = new Triangle(10, 6, 8);
            Assert.IsTrue(triangle.IsRight);
        }
        [Test]
        public void IsRight_false_NotRightTriangle()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.IsFalse(triangle.IsRight);
        }
    }
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void Area_0_NoArguments()
        {
            Circle circle = new Circle();
            Assert.Zero(circle.Area);
        }
        [Test]
        public void Area_Correct_PositiveArguments()
        {
            double r = 5;
            Circle circle = new Circle(r);
            double area = Math.PI * r * r;
            Assert.AreEqual(area, circle.Area,0.000001);
            circle.Set(11);
            Assert.AreEqual(380.132711, circle.Area,0.000001);
        }
        [Test]
        public void new_ExceptionThrown_NotPositiveValues()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));

        }
    }
}