using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Call
    {
        private string date;
        private string time;
        private string dialledPhoneNumber;
        private int duration;

        public Call(string date, string time, string dialledPhoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        public string Date 
        { 
            get
            {
                return this.date;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Date is empty!");
                }
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Time is empty!");
                }
                this.time = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Date is empty!");
                }
                if (value.Length != 10 && value.Length != 13)
                {
                    throw new ArgumentException("Invalid phone number!");
                }
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration 
        { 
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0 || value > 3600)
                {
                    throw new IndexOutOfRangeException("Call duration must be between 0 and 3600 seconds!");
                }
                this.duration = value;
            } 
        }
    }
}
