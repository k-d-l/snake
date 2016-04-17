using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xStart, int xFinish, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xStart; x <= xFinish; x++)
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
