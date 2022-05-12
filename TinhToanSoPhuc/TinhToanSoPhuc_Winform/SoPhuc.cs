using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToanSoPhuc_Winform
{
    class SoPhuc
    {
        //Phan thuc r, phan ao i
        public double r, i;

        public SoPhuc()
        {

        }
        public SoPhuc(double r, double i)
        {
            this.r = r;
            this.i = i;

        }

        public void InSoPhuc()
        {
            Console.WriteLine("{0} + ({1}i)", r, i);
        }

        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            kq.r = a.r + b.r;
            kq.i = a.i + b.i;
            return kq;
        }
        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            kq.r = a.r - b.r;
            kq.i = a.i - b.i;
            return kq;
        }
        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            kq.r = a.r * b.r - a.i * b.i;
            kq.i = a.r * b.i + b.r * a.i;
            return kq;
        }
        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            SoPhuc kq = new SoPhuc();
            kq.r = (a.r * b.r + a.i * b.i) / (b.r * b.r + b.i * b.i);
            kq.i = (a.i * b.r - a.r * b.i) / (b.r * b.r + b.i * b.i);
            return kq;
        }
    }
}
