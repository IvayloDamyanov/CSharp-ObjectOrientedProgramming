using System;
using System.Collections.Generic;

namespace HomeWork
{
    public class GSM
    {
        private const decimal priceMin = 0.37m;
        private string _model;
        private string _manifacturer;
        private double? _price = null;
        private string _owner = null;
        private Battery _battery;
        private Display _display;
        public static GSM IPhone4s = new GSM("IPhone4s", "Apple", 999.99, "not Me", "IBat", 6.1, 1.5, 0, "6'", "16M");

        public GSM(string model, string manifacturer, double? price = null, string owner = null, string batteryModel = null, double? batteryHoursIdle = null, double? batteryHoursTalk = null, int? batType = null, string displaySize = null, string displayNumOfColours = null)
        {
            this._model = model;
            this._manifacturer = manifacturer;
            this._price = price;
            this._owner = owner;
            this._battery = new Battery(batteryModel, batteryHoursIdle, batteryHoursTalk, batType);
            this._display = new Display(displaySize, displayNumOfColours);
        }

        public override string ToString()
        {
            string output = string.Format("Model: {0}\nManifacturer: {1}\nPrice: {2}\nOwner: {3}\n\nBattery:\n{4}\n\nDisplay:\n{5}\n", _model, _manifacturer, _price, _owner, _battery.ToString(), _display.ToString());
            return output;
        }

        public List<Call> CallHistory = new List<Call>();

        public void addCallToHistory(Call input)
        {
            CallHistory.Add(input);
        }

        public void delCallFromHistory(int callNum)
        {
            CallHistory.RemoveAt(callNum);
        }

        public void clearCallHistory()
        {
            CallHistory.Clear();
        }
        public decimal CallPrice()
        {
            int duration = 0;
            foreach (Call call in CallHistory)
            {
                duration += call._durationSec;
            }

            decimal result = ((decimal)duration / 60) * priceMin;
            return result;
        }
    }
}
