using System;

namespace HomeWork
{
    public class Battery
    {
        private string _model;
        private double? _hoursIdle;
        private double? _hoursTalk;
        public enum batteryType
        {
            Unknown,
            Li_Ion,
            NiMH,
            NiCd
        }
        private batteryType? _batType = null;
        public Battery(string model = null, double? hoursIdle = null, double? hoursTalk = null, int? batType = null)
        {
            this._model = model;
            this._hoursIdle = hoursIdle;
            this._hoursTalk = hoursTalk;
            this._batType = (batType == null ? _batType : (batteryType)batType);
        }
        public override string ToString()
        {
            string output = string.Format("Model: {0}\nHoursIdle: {1}\nHoursTalk: {2}\nBattery Type: {3}", _model, _hoursIdle, _hoursTalk, _batType);
            return output;
        }
    }
}
