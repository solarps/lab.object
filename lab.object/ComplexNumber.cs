using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.obj
{
    public class ComplexNumber
    {
        int x, y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public ComplexNumber(int seed){
            Random r = new Random(seed);
            x = r.Next(0, 10);
            y = r.Next(0, 10);
        }
        public ComplexNumber() {}
        public string PtintNum()
        {
            string data = $"{x} + {y}i";
            return data;
        }
        public static ComplexNumber operator + (ComplexNumber A, ComplexNumber B)
        {
            ComplexNumber sum = new ComplexNumber();
            sum.X = A.X + B.X;
            sum.Y = A.Y + B.Y;
            return sum;
        }
        public static ComplexNumber operator - (ComplexNumber A, ComplexNumber B)
        {
            ComplexNumber razn = new ComplexNumber();
            razn.X = A.X - B.X;
            razn.Y = A.Y - B.Y;
            return razn;
        }
        public static ComplexNumber operator * (ComplexNumber A, ComplexNumber B)
        {
            ComplexNumber proizv = new ComplexNumber();
            proizv.X = (A.X * B.X - A.Y * B.Y);
            proizv.Y = (A.X * B.Y + A.Y * B.X);
            return proizv;
        }
        public static ComplexNumber operator / (ComplexNumber A, ComplexNumber B)
        {
            ComplexNumber del = new ComplexNumber();
            del.X = (A.X * B.X + A.Y * B.Y) / (int)(Math.Pow(B.X, 2) + Math.Pow(B.Y, 2));
            del.Y = (B.X * A.Y - B.Y * A.X) / (int)(Math.Pow(B.X, 2) + Math.Pow(B.Y, 2));
            return del;
        }
    }
}
   
