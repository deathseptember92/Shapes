using System;
using Shapes_Lib;


namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle shape = ShapesLib.CreateShape(25, 39, 15);

            Console.WriteLine(shape.IsRectangular());
            Console.WriteLine(ShapesLib.GetSquare(shape));

            Console.ReadLine();
        }
    }


}
