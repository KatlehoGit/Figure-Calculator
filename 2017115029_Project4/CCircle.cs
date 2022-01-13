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
    class CCircle : CFigure
    {
        private double radious;
        public double Radious
        {
            get { return radious; }
            set { this.radious = value; }
        }
        public override double Area()
        {
            double area = Math.PI * ((int)(Radious) ^ 2);
            //https://www.google.com/search?q=area+of+a+circle+formula&oq=area+&aqs=chrome.0.69i59j69i57j0l6.2135j0j7&sourceid=chrome&ie=UTF-8
            return area;
        }

        
        public override double Perimeter()
        {
            double perimeter = 2 * (Math.PI * Radious);
            //https://www.google.com/search?sxsrf=ACYBGNTKapkrGojyj9Yy7pC355MALey85A%3A1583064831464&ei=_6ZbXt2DHMyYlwS3oKzYBg&q=perimeter+of+a+circle&oq=area+of+a+circle+formula&gs_l=psy-ab.1.4.0i71l8.0.0..124343...0.1..0.0.0.......0......gws-wiz.92qIKTjHXvM
            return perimeter;
        }
    }
}
