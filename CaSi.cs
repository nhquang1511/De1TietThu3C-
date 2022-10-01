using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1TietThu3
{
    public class CaSi : Nguoi, IBietMua
    {
        private DongNhac dongNhac;
        private int namBatDauHat;
        private double thuNhapTrungBinhMotNam;
        public CaSi(string hoTen, string phai, DongNhac dongNhac
            , int namBatDauHat, double thuNhapTrungBinhMotNam) : base(hoTen, phai)
        {
            this.dongNhac = dongNhac;
            this.namBatDauHat = namBatDauHat;
            this.thuNhapTrungBinhMotNam = thuNhapTrungBinhMotNam;
        }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine("dong nhac: " + dongNhac);
            Console.WriteLine("nam bat dau hat: " + namBatDauHat);
            Console.WriteLine("thu nhap chung binh mot nam: " + thuNhapTrungBinhMotNam);
        }

        public override void khaNangHat()
        {
            base.khaNangHat();
            Console.WriteLine("hat hay nhung bai hit");
        }

        public void khaNangMua()
        {
            Console.WriteLine("mua rat hay");
        }

        public override void TaiNangBamSinh()
        {
            Console.WriteLine("hat bam sinh hay");
        }

    }
}

