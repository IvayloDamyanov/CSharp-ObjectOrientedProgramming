using System;

namespace HomeWork
{
    public class Display
    {
        private string _size;
        private string _numOfColours;
        public Display(string size = null, string numOfColours = null)
        {
            this._size = size;
            this._numOfColours = numOfColours;
        }
        public override string ToString()
        {
            string output = string.Format("Size: {0}\nNumber of colours: {1}", _size, _numOfColours);
            return output;
        }
    }
}
