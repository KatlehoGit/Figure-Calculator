/*2017115029
Katleho Moalosi
CSIS2614
Project 4*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017115029_Project4
{
    class CRectangle : CFigure
    {
        private double length;
        public double Length
        {
            get { return length; }
            set { this.length = value; }
        }
        private double width;
        public double Width
        {
            get { return width; }
            set { this.width = value; }
        }
        public override double Area()
        {
            double area = Width * Length;
            //https://www.google.com/search?sxsrf=ACYBGNQCdLaIgNnVErxdaCX1hz1586fPxA%3A1583065008175&ei=sKdbXu6wCvXjgwfUg6O4Dg&q=area+of+a+rectangle+formula&oq=area+of+a+rectangle+formula&gs_l=psy-ab.3..0i71l8.327523.328348..329700...0.1..0.1310.1310.7-1......0....1..gws-wiz.O4Dt215Bp44&ved=0ahUKEwjuyN_boPnnAhX18eAKHdTBCOcQ4dUDCAs&uact=5
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * (Length + Width);
            //https://www.google.com/search?sxsrf=ACYBGNQ-0f4-hSx2JleCK8TV5Rpgkn--Xw%3A1583064959972&ei=f6dbXv-IO4ykgwediJ94&q=perimeter+of+a+rectangle+formula&oq=perimeter+of+a+Rect&gs_l=psy-ab.1.0.35i39j0i67j0l8.40339.41382..44292...0.2..0.543.1839.4-3j1......0....1..gws-wiz.......0i71j0i20i263.G5KcRxBl43o
            return perimeter;
        }
    }
}
