using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students;

namespace ExtractStudentsByTwoMark
{
    public static class ExtractStudentsByTwoMark
    {
        public static int MarkCount(this List<int> list, int mark)
        {
            int count = 0;
            foreach (dynamic item in list)
            {
                if (item == mark)
                {
                    count ++;
                }
            }
            return count;
        }
    }
}
