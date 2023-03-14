using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Retangle
    {
        public int Width;
        public int Length;
        public Retangle(int width, int length) 
        {
            Length = length;
            Width = width;
        }
        public int Arear()
        {
            return Width * Length;
        }
        public int Diemeterr()
        {
            return (Width + Length) / 2;
        }
        public void displayR()
        {
            Console.WriteLine(Arear());
            Console.WriteLine(Diemeterr());
        }
        
    }
}
