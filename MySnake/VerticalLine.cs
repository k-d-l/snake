using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yStart, int yFinish, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yStart; y <= yFinish; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point pp in pList)
            {
                pp.Draw();
            }



        }
    }
}
