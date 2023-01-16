using System;

namespace Interpolation.Classes
{
    public class MyPoint
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public MyPoint(string x, string y)
        {
            _x = Convert.ToDouble(x);
            _y = Convert.ToDouble(y);
        }

        public MyPoint(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public MyPoint()
        {
            _x = 0;
            _y = 0;
        }

        //Виводить координати точки у якості строки
        public override string ToString() => $"{_x}; {_y}";
    }
}
