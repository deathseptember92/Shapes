using System;
using System.Diagnostics.CodeAnalysis;

namespace Shapes_Lib
{

    public interface IShape
    {
        double GetSquare();
    }

    public struct Round : IShape,IEquatable<Round>
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

        public bool Equals(Round other)
        {
            return radius == other.radius;
        }

        public double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(radius,2),2);
        }
    }

    public struct Triangle : IShape,IEquatable<Triangle>
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
            return Math.Pow(sides[2],2) == (Math.Pow(sides[0],2) + Math.Pow(sides[1],2));
        }

        public double GetSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),2);
        }

        public bool Equals(Triangle other)
        {
            return a == other.a && b == other.b && c == other.c;
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
