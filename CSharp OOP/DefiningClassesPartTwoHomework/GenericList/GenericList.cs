using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> where T: IComparable<T>
    {
        // Fields
        private int index = 0;

        private int genericListLength;

        private T[] data;
        // Constructor
        public GenericList(int length)
        {
            if (length <= 0)
            {
                throw new IndexOutOfRangeException("There must be at least one element in the generic list!");
            }
            this.Data = new T[length];
            this.genericListLength = length;
        }
        // Properties
        public T[] Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public int Length
        {
            get
            {
                return this.genericListLength;
            }
            private set
            {
                this.genericListLength = value;
            }
        }
        // Methods
        public void Add(T element)
        {
            if (genericListLength <= index)
            {
                AutoGrow();
            }
            this.Data[index] = element;
            this.index++;
        }

        public void Remove(int index)
        {
            this.Data[index] = default(T);
        }

        public void Insert(int index, T value)
        {
            this.Data[index] = value;
        }

        public void Clear()
        {
            for (int i = 0; i < this.data.Length; i++)
            {
                this.Data[i] = default(T);
            }
        }

        public int Find(T value)
        {
            int searchedIndex = -1;

            for (int i = 0; i < this.data.Length; i++)
            {
                if (value.CompareTo(this.Data[i]) == 0)
                {
                    searchedIndex = i;
                    break;
                }
            }
            return searchedIndex;
        }

        public T Min()
        {
            T result = default(T);
            if (this.Length > 0)
            {
                result = this.Data[0];
                for (int i = 1; i < this.Data.Length; i++)
                {
                    if (result.CompareTo(this.Data[i]) < 0)
                    {
                        result = this.Data[i];
                    }
                }
            }
            return result;
        }

        public T Max()
        {
            T result = default(T);
            if (this.Length > 0)
            {
                result = this.Data[0];
                for (int i = 1; i < this.Data.Length; i++)
                {
                    if (result.CompareTo(this.Data[i]) > 0)
                    {
                        result = this.Data[i];
                    }
                }
            }
            return result;
        }

        private void AutoGrow()
        {
            int newSize = Length * 2;
            T[] newData = new T[newSize];

            for (int i = 0; i < this.Data.Length; i++)
            {
                newData[i] = this.Data[i];
            }
            this.Data = newData;
            this.Length = newSize;
        }
        // Indexer
        public T this [int index]
        {
            get
            {
                return this.Data[index];
            }
            set
            {
                this.Data[index] = value;
            }
        }
        //String override
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Data.Length; i++)
			{
                result.AppendFormat("Element[{0}]: {1}", i, this.Data[i]);
                if (i != this.Data.Length - 1)
                {
                    result.AppendLine();
                }
			}
            return result.ToString();
        }
    }
}
