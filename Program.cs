using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1TietThu3
{
    class Program
    {
        static void Main(string[] args)
        {
            CaSi casi1 = new CaSi("Nguyen Van A", "nam", DongNhac.Rock, 2000, 120000000);
            DienVienXiec dienvienxiec1 = new DienVienXiec("Nguyen Van B", "nam", 2001, 100000000, TroXiec.XiecDuDay);
            casi1.inThongTin();
            dienvienxiec1.inThongTin();
            Console.ReadKey();
        }
    }
}
