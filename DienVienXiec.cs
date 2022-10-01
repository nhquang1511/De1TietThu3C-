using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1TietThu3
{
    public class DienVienXiec : Nguoi, IBietLamXiec
    {
        private int namBatDauDien;
        private double thuNhapTrungBinhMotNam;
        private TroXiec troXiec;
        public DienVienXiec(string hoTen, string phai, int namBatDauDien,
            double thuNhapTrungBinhMotNam, TroXiec troXiec) : base(hoTen, phai)
        {
            this.namBatDauDien = namBatDauDien;
            this.thuNhapTrungBinhMotNam = thuNhapTrungBinhMotNam;
            this.troXiec = troXiec;
        }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine("nam bat dau dien: " + namBatDauDien);
            Console.WriteLine("tro xiec: " + troXiec);
            Console.WriteLine("thu nhap trung binh mot nam: " + thuNhapTrungBinhMotNam);
        }

        public override void khaNangHat()
        {
            base.khaNangHat();
            Console.WriteLine("hat ca co");
        }

        public void khaNangLamXiec()
        {
            Console.WriteLine("lam viec lien tuc");
        }

        public override void TaiNangBamSinh()
        {
            Console.WriteLine("biet mua deo tu nho");
        }

    }
}
