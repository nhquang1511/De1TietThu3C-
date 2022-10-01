using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1TietThu3
{
    public abstract class Nguoi : IBietHat
    {

        private String hoTen;
        private String phai;
        public Nguoi(String hoTen, String phai)
        {
            this.hoTen = hoTen;
            this.phai = phai;
        }
        public virtual void inThongTin()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("gioi tinh: " + phai);
        }


        public virtual void khaNangHat()
        {
            Console.WriteLine("co kha nang hat");
        }

        public abstract void TaiNangBamSinh();

        
    }
}
