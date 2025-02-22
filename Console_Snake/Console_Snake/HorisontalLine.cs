﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class HorisontalLine : Figure
    {
       
        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Drow();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
