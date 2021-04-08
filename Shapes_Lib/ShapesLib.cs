using System;

namespace Shapes_Lib
{

    public interface IShape
    {
        double GetSquare();
    }

    public struct Round : IShape
    {

        private double radius;

        public Round(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Wrong argument.");
            }
            this.radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }

    public struct Triangle : IShape
    {

        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Wrong argument.");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public bool IsRectangular()
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Sqrt(sides[2]) == (Math.Sqrt(sides[0]) + Math.Sqrt(sides[1]));
        }

        public double GetSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }


    public static class ShapesLib
    {
        /// <summary>
        /// Create Round
        /// </summary>
        /// <param name="radius">Round radius</param>
        /// <returns></returns>
        public static Round CreateShape(double radius) 
        {
            return new Round(radius);
        }

        /// <summary>
        /// Create Triangle
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <param name="c">Side C</param>
        /// <returns></returns>
        public static Triangle CreateShape(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        /// <summary>
        /// Returns shape's square
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public static double GetSquare(IShape shape)
        {
            return shape.GetSquare();
        }

    }

}
