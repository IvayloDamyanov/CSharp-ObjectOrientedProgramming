using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Call
    {
        public DateTime _dateTime;
        public string _dialedNum;
        public int _durationSec;
        public Call(DateTime dateTime, string dialedNum, int durationSec)
        {
            this._dateTime = dateTime;
            this._dialedNum = dialedNum;
            this._durationSec = durationSec;
        }
        public override string ToString()
        {
            string output = string.Format("Date: {0:dd}/{0:MM}\nTime: {0:HH}:{0:mm}\nDialed Number: {1}\nDuration: {2}\n", _dateTime, _dialedNum, _durationSec);
            return output;
        }
    }
}
