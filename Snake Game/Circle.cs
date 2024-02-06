using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Game
{
    internal class Circle //kjo klase na ndihmon te mbajme te shenuara  vlerat e x,y te cdo rrethi qe e vizatojme ne ekran
    {
        public int X {  get; set; } 
        public int Y { get; set; }

        public Circle()
        { 
            X = 0;
            Y = 0;
        }

    }
}
