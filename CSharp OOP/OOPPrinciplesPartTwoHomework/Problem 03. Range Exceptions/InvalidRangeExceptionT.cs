using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException where T: IComparable<T>
    {
        // Fields
        private T startRange;
        
        private T endRange;
        // Constructors
        public InvalidRangeException(string msg, T start, T end, Exception innerEx)
            : base(msg, innerEx)
        {
            this.StartRange = start;
            this.EndRange = end;
        }

        public InvalidRangeException(string msg, T start, T end)
            : this(msg, start, end, null)
        {
            this.StartRange = start;
            this.EndRange = end;
        }
        // Properties
        public T StartRange
        {
            get { return this.startRange; }
            private set { this.startRange = value; }
        }

        public T EndRange
        {
            get { return this.endRange; }
            private set { this.endRange = value; }
        }
    }
}
