using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Circle
    {
        
        const float PI = 3.14f;
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle() { 

        }
       public double Diametor()
        {

            return Radius * 2;

        }
        public double Area()
        {
            return Radius * Radius * PI;
        }
        public double Perimetor()
        {
            return Radius * 2 * PI;
        }
        public void display()
        {
            Console.WriteLine(Area());
            Console.WriteLine(Diametor());
            Console.WriteLine(Perimetor());
       }
    }
}

  

