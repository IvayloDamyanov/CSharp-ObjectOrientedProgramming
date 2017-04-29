using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class Startup
    {
        static void Main()
        {
            #region Instances initialization
            InvalidRangeException<int> integers = new InvalidRangeException<int>(1, 100);

            DateTime start = DateTime.ParseExact("01.01.1980", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact("31.12.2013", "dd.MM.yyyy", CultureInfo.InvariantCulture);
            InvalidRangeException<DateTime> dateTime = new InvalidRangeException<DateTime>(start, end);
            #endregion

            integers.Result();
            dateTime.Result();
        }
    }
}
