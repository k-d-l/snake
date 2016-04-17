using System;
using System.Collections.Generic;

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

            List<int> NewList = new List<int>();

            NewList.Add(0);
            NewList.Add(1);
            NewList.Add(2);

            int x = NewList[0];
            int y = NewList[1];
            int z = NewList[2];

            Console.WriteLine("x=" + x + ", y=" + y + ", z=" + z);

            foreach (int i in NewList)
                Console.WriteLine(i);


            List<Point> Pp = new List<Point>();
            Pp.Add(p1);
            Pp.Add(p2);
            Point p3 = new Point(6,6,'D');
            Point p4 = new Point(7, 7, 'G');
            Pp.Add(p3);
            Pp.Add(p4);

            foreach (Point po in Pp)
                po.Draw();


            HorizontalLine hLine = new HorizontalLine(4,10,22,'+');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(10, 22, 5, '+');
            vLine.Draw();

            Console.ReadLine();
        }

    }
}
