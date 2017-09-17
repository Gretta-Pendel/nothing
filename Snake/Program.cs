using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(5,15,8,'_');
            hLine.Drow();
            VerticalLine vLine = new VerticalLine(9,14,5,'|');
            vLine.Drow();

            HorizontalLine hLine1 = new HorizontalLine(5, 15, 15, '_');
            hLine1.Drow();
            VerticalLine vLine1 = new VerticalLine(9, 14, 15, '|');
            vLine1.Drow();



            Console.ReadLine();
        }

    }
}
