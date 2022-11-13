using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaritaMesafeOlcer
{
    public class Nokta
    {
        public int X { get; set; }

        public int Y { get; set; }

        public double Uzaklik(Nokta diger)
        {
            int deltaX = diger.X - X;
            int deltaY = diger.Y - Y;
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
    }
}
