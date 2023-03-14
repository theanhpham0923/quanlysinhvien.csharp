using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Circle cr = new Circle();
            
            Triangle Tri = new Triangle(a, b, c);
            Tri.Check();
            
            Tri.displayT();
            
            /*kiem tra xem thuoc loai tam giac nao*/
            /**/
        }
    }
}
