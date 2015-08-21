using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class GSM
    {
        //Static fields
        private static GSM IPhone4s = new GSM("Apple", "IPhone 4S", 400, "Jimmy Hendrix", new Battery("GB/T19437-2013", 200, 14, BatteryType.NiMH), new Display(3.5, 16));
        //Constants
        private const string DefaultOwner = null;
        private const Battery DefaultBattery = null;
        private const Display DefaultDisplay = null;
        //Fields
        private string owner;
        private string manufacturer;
        private List<Call> callHistory = new List<Call>();
        private string model;
        private double? price;
        //Constructors
        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = null;
            this.Owner = DefaultOwner;
            this.Battery = DefaultBattery;
            this.Display = DefaultDisplay;
        }

        public GSM(string manufacturer, string model, double price, string owner, Battery battery, Display display) 
            : this(manufacturer, model)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
        //Static properties
        public static GSM IPhone4S
        {
            get
            {
                return IPhone4s;
            }
        }
        //Properties
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("GSM manufacturer must have at least 2 characters!");
                }
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GSM model must be atleast 1 character long!");
                }

                this.model = value;
            }
        }

        public double? Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be a negative number!");
                }
                this.price = value;
            } 
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != null)
                {
                    if (value.Length < 6)
                    {
                        throw new ArgumentException("Owner's name must have at least 6 characters!");
                    }
                }
                this.owner = value;
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }
        //Methods
        public void AddCall(string date, string time, string dialledPhoneNumber, int duration)
        {
            this.CallHistory.Add(new Call(date, time, dialledPhoneNumber, duration));
        }

        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.RemoveAll(x => x.Duration >= 0);
        }

        public decimal CallPrice(decimal price)
        {
            decimal callPrice = 0;
            foreach (var call in CallHistory)
            {
                callPrice += (call.Duration * price) / 60;
            }
            return callPrice;
        }

        public string ShowCallHistory()
        {
            StringBuilder result = new StringBuilder();

            foreach (var call in CallHistory)
            {
                result.AppendLine("Date                 : " + call.Date);
                result.AppendLine("Time                 : " + call.Time);
                result.AppendLine("Dialled Phone Number : " + call.DialledPhoneNumber);
                result.AppendLine("Duration             : " + call.Duration + "s");
                result.AppendLine(new string('-', 50));
            }
            if (CallHistory.Count == 0)
            {
                result.Append("The call history is empty!");
            }
            return result.ToString();
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            if (this.Manufacturer != null)
            {
                result.Append("Manufacturer".PadRight(14, ' '));
                result.Append(": ");
                result.Append(this.Manufacturer);
                result.AppendLine();
            }
            if (this.Model != null)
            {
                result.Append("Model".PadRight(14, ' '));
                result.Append(": ");
                result.Append(this.Model);
                result.AppendLine();
            }
            if (this.Price != null)
            {
                result.Append("Price".PadRight(14, ' '));
                result.Append(": ");
                result.Append(this.Price + "$");
                result.AppendLine();
            }
            if (this.Owner != null)
            {
                result.Append("Owner".PadRight(14, ' '));
                result.Append(": ");
                result.Append(this.Owner);
                result.AppendLine();
            }
            if (this.Battery != null)
            {
                result.Append("Battery Model".PadRight(14, ' '));
                result.Append(": ");
                result.Append(this.Battery.Model);
                result.AppendLine();

                result.Append("Battery Type".PadRight(14, ' '));
                result.Append(": ");
                result.Append(this.Battery.BatteryType);
                result.AppendLine();

                if (this.Battery.IdleHours != null)
                {
                    result.Append("Idle Hours".PadRight(14, ' '));
                    result.Append(": ");
                    result.Append(this.Battery.IdleHours + "h");
                    result.AppendLine();
                }
                if (this.Battery.TalkHours != null)
                {
                    result.Append("Talk Hours".PadRight(14, ' '));
                    result.Append(": ");
                    result.Append(this.Battery.TalkHours + "h");
                    result.AppendLine();
                }
            }
            if (this.Display != null)
            {
                if (this.Display.Size != null)
                {
                    result.Append("Display Size".PadRight(14, ' '));
                    result.Append(": ");
                    result.Append(this.Display.Size + "inch");
                    result.AppendLine();
                }
                if (this.Display.Colors != null)
                {
                    result.Append("Display Colors".PadRight(14, ' '));
                    result.Append(": ");
                    result.Append(this.Display.Colors + "M");
                }
            }
            return result.ToString();
        }
    }
}
