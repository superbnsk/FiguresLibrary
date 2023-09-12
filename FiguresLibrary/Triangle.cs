using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    //Треугольник
    public class Triangle : Figure, ITriangle
    {
        //стороны треугольника
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0) throw new Exception("Side a can't be <= 0");
            if (b <= 0) throw new Exception("Side b can't be <= 0");
            if (c <= 0) throw new Exception("Side c can't be <= 0");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void SetA(double a)
        {
            if (a <= 0) throw new Exception("Side a can't be <= 0");
            this.a = a;
        }

        public void SetB(double b)
        {
            if (b <= 0) throw new Exception("Side b can't be <= 0");
            this.b = b;
        }

        public void SetC(double c)
        {
            if (c <= 0) throw new Exception("Side c can't be <= 0");
            this.c = c;
        }
        public double GetA() => a;
        public double GetB() => b;
        public double GetC() => c;

        public override double Square()
        {
            double p2 = (a + b + c) / 2;
            return Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
        }

        public bool IsRectangular()
        {
            if ((a * a) == (b * b) + (c * c)) return true;
            if ((b * b) == (a * a) + (c * c)) return true;
            if ((c * c) == (a * a) + (b * b)) return true;
            return false;
        }
    }
}
