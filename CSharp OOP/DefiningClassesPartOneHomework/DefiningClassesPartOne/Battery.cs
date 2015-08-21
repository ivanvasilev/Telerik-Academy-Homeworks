using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Battery
    {
        private string model;
        private int? talkHours;
        private int? idleHours;

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
                    throw new ArgumentNullException("Battery model must be atleast 1 character long!");
                }

                this.model = value;
            }
        }

        public int? IdleHours
        {
            get
            {
                return this.idleHours;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Idle hours must be over 0!");
                }

                this.idleHours = value;
            }
        }

        public int? TalkHours 
        {
            get
            {
                return this.talkHours;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Talk hours must be over 0!");
                }

                this.talkHours = value;
            }
        }

        public BatteryType BatteryType { get; set; }

        public Battery(string model)
        {
            this.Model = model;
            this.IdleHours = null;
            this.TalkHours = null;
            this.BatteryType = BatteryType.unknown;
        }

        public Battery(string model, int idleHours, int talkHours)
            : this(model)
        {
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.BatteryType = BatteryType.unknown;
        }

        public Battery(string model, int idleHours, int talkHours, BatteryType batteryType)
            : this(model, idleHours, talkHours)
        {
            this.BatteryType = batteryType;
        }
    }
}
