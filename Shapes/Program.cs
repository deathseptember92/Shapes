using System;
using Shapes_Lib;


namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle shape = ShapesLib.CreateShape(12, 15, 18);
            Console.WriteLine(ShapesLib.GetSquare(shape));

            Console.ReadLine();
        }
    }


}
