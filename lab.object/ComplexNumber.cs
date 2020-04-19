using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.obj
{
    public struct xy
    {
        public double x;
        public double y;
    };
  
    public class ComplexNumber:Form1
    {
        public xy[] num;
        Random r=new Random();
        public void calculation()
        {
            num = new xy[3];
            
            for (int i = 0; i < num.Length; i++)
            {
                num[i].x = r.Next(0, 10);
                num[i].y = r.Next(0, 10);
                A[i].a = num[i].x + num[i].y * Math.Sqrt(-1);
            }
            
        }
        public double modul()
        {
            return Math.Pow(A[1].a, 4) + (A[0].a - A[1].a) / A[2].a * A[0].a;
        }
        public void output()
        {
            string data = "";
            data += $"Modul = {modul()}";
        }

    }

    

}
   
