using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T>
    {
        private T _min;
        private T _max;

        public T Min
        {
            get { return _min; }
        }
        public T Max
        {
            get { return _max; }
        }

        public InvalidRangeException(T min, T max)
        {
            this._min = min;
            this._max = max;
        }

        public void Result()
        {
            Console.WriteLine("The value should be in the range {0} : {1}", _min, _max);
        }

        //check.ToString().CompareTo(Min.ToString()) == 1 || check.ToString().CompareTo(Max.ToString()) == -1
    }
}
