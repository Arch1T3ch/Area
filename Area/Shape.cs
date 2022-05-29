using System;

namespace Shapes
{
    abstract public class Shape 
    {
        protected double _area;
        public double Area => _area;
        public Shape() {
        _area = 0;
        }
    }
       public class Circle:Shape
    {
        public Circle()
        {
            _area = 0;
        }
        public Circle(double radius) {
            Set(radius);
        }
        public void Set(double radius) {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Circle radius can't be negative!");
            _area = Math.PI * radius * radius;
        }
    }

    public class Triangle : Shape
    {
        private bool _isRight;
        public bool IsRight => _isRight;
        public Triangle()
        {
            _area = 0;
        }
        public Triangle(double side1, double side2, double side3) { 
            Set(side1,side2,side3);
        }
        public void Set(double side1,double side2,double side3) {
            if (side1<0|| side2 < 0|| side3 < 0)
                throw new ArgumentOutOfRangeException("Triangle sides length can't be negative!");
            double p = (side1 + side2 + side3) / 2;
            _area = Math.Sqrt(Math.Abs(p *(p-side1)* (p - side2)* (p - side3)));
            double maxside= Math.Max(Math.Max(side1,side2),side3);
            _isRight = maxside *maxside== side1*side1 + side2 * side2 + side3 * side3- maxside * maxside;
        }
    }

}
