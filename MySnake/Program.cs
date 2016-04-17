using System;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '0');
                p1.Draw();

             Point p2 = new Point(2, 5, '%');
                p2.Draw();

            Console.ReadLine();
        }
       
    }
}
