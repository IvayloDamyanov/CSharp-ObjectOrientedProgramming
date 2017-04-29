using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private double _weekSalary;
        private double _workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this._weekSalary = weekSalary;
            this._workHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double output = _weekSalary / (_workHoursPerDay * 7);
            return output;
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += string.Format(", Money Per Hour: {0:0.00}", this.MoneyPerHour());
            return output;
        }

        public double WeekSalary
        {
            get
            {
                return this._weekSalary;
            }
        }
        public double WorkHoursPerDay
        {
            get
            {
                return this._workHoursPerDay;
            }
        }
    }
}
