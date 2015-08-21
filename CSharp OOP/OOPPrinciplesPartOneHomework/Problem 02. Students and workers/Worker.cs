using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        // Fields
        private decimal weekSalary;
        private int workHoursPerDay;
        // Constructor
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHoursPerDay;
        }
        // Properties
        public decimal WeekSalary 
        { 
            get
            {
                if (this.weekSalary < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary can't be a negative number!");
                }
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary can't be a negative number!");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHours 
        { 
            get
            {
                if (this.workHoursPerDay < 0 || this.workHoursPerDay > 16)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be in the range [1, 16]");
                }
                return this.workHoursPerDay;
            }
            private set
            {
                if ( value < 0 || value > 16)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be in the range [1, 16]");
                }
                this.workHoursPerDay = value;
            }
        }
        // Method
        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / (this.WorkHours * 5m));
        }
    }
}
