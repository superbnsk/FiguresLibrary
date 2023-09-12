using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    public class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius <= 0) throw new Exception("Radius can't <= 0");
            this.radius = radius;
        }

        public void SetRadius(double radius)
        {
            if (radius <= 0) throw new Exception("Radius can't be <= 0");
            this.radius = radius;
        }

        public double GetRadius() => radius;

        public override double Square() => Math.PI * radius * radius;
    }
}
