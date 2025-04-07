using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_28_02
{
    public static class Standart
    {
        private static int studentCount = 100;
        private static int teachersCount = 10;


        public static bool isFits(College a)
        {
            return studentCount <= a.studentCount && teachersCount <= a.teachersCount;
        }
    }
}
