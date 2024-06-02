using System;
namespace TriangleTypeIdentifier
{
    class TriangleTypeIdentifier
    {
        static void Main(string[] args)
        {
            //To take user input
            Console.WriteLine("Type the length of the triangle side AB");
            int sideA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the length of the triangle side BC");
            int sideB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the length of the triangle side CA");
            int sideC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");//To give space

            //To check what type of triangle it is
            if (Convert.ToBoolean(sideA == sideB && sideB == sideC && sideC == sideA))
            {
                Console.WriteLine("It is an Equilateral triangle");
            }
            else if (Convert.ToBoolean(sideA == sideB || sideA == sideC || sideB == sideC ))
            {
                Console.WriteLine("It is an Isosceles triangle");
            }
            else
            {
                Console.WriteLine("It is a Scalene triangle");
            }
        }
    }
}
