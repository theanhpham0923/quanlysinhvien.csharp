using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Triangle
    {
        public int A;
        public int B;
        public int C;
        public int P;
        double H;
        
        int check = 0;
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        /*ham tra ve loai tam giac
         tam giac thuong 
        tam giac vuong
        tam giac can
        tam giac deu
        tam giac vuong can
        */
        public int CheckTypeTriangle()
        {
            if (Check() == 0)
            {
                Console.WriteLine("Day la tam giac");
                if (A == B && A != C)
                {
                    H = (A * A * B * B) / (A * A + B * B);
                    Console.WriteLine("Day la tam giac can");
                    Console.WriteLine("Area: " + (C * H) / 2);

                } else if(A*A + B*B == C*C && A!= B)
                {
                    Console.WriteLine("Day la tam giac vuong");
                    Console.WriteLine("Area: " + (A * B) / 2);
                }
                else if (A * A + B * B == C * C && A == B)
                    {
                        Console.WriteLine("Day la tam giac vuong can");
                        Console.WriteLine("Area: " + (C * C) / 2);

                    }
                else if (A == B && A == C)
                {
                    H = (A * Math.Sqrt(3)) / 2;
                    Console.WriteLine("Day la tam giac deu");
                    Console.WriteLine("Area: " + (A * H) / 2);
                }
                else 
                {

                    Console.WriteLine("Day la tam giac thuong");
                    p();
                    Console.WriteLine("Area: " + Area());
                }


            }
                
               
            
           if (Check()==1 || Check()==2)
            {

                Console.WriteLine("Day khong phai la tam giac");
            }
            return check;

        }
        
        public int Check()
        {
            int Errrorcode = 0;
            if (A <= 0 || B <= 0 || C <= 0)
            {
                Errrorcode = 1;
            }
            if (A + B <= C || B + C <= A || A + C <= B) 
            {
                Errrorcode = 2;
            }
            return Errrorcode;
        }

        public int perimeter()
        {
            return A + B + C;
        }
        public double p() 
        {
            return (A + B + C) / 2;
        }
        public double Area()
        {
            
            return (int)Math.Sqrt(p()*(p() - A)*(p() - B)* (p() - C));
        }
        public void displayT()
        {

            CheckTypeTriangle();
        }
    }
}
