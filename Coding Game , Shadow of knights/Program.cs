﻿using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Shadow
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);

        int x1 = 0, y1 = 0, x2 = W - 1, y2 = H - 1;
        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)


            if (bombDir.Contains("U"))
            {
                y2 = y - 1;
            }
            else if (bombDir.Contains("D"))
            {
                y1 = y + 1;
            }

            if (bombDir.Contains("L"))
            {
                x2 = x - 1;
            }
            else if (bombDir.Contains("R"))
            {
                x1 = x + 1;
            }

            x = x1 + (x2 - x1) / 2;
            y = y1 + (y2 - y1) / 2;



            // the location of the next window Batman should jump to.
            Console.WriteLine(string.Format("{0} {1}", x, y));
            //Console.WriteLine("3 7");
        }
    }
}