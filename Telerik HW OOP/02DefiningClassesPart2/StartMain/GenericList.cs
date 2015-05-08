namespace StartMain
{
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private int arraySize;

        private int index;

        private T[] arr;

        private int elementsInArray;

        public GenericList(int arraySize)
        {
            this.arraySize = arraySize;
            this.arr = new T[arraySize];
        }

        public void Add(T element)
        {
            if (elementsInArray == arraySize)
            {
                AutoGrow();
            }
            arr[index] = element;
            index++;
            elementsInArray++;
        }

        public void Insert(int Index, T element)
        {
            if (elementsInArray == arraySize)
            {
                AutoGrow();
            }
            T[] newArr = new T[arraySize];
            for (int i = 0; i < Index; i++)
            {
                newArr[i] = this.arr[i];
            }

            newArr[Index] = element;

            for (int i = Index + 1; i < elementsInArray + 1; i++)
            {
                newArr[i] = this.arr[i - 1];
            }

            this.arr = newArr;
            elementsInArray++;
        }

        public void RemoveAtIndex(int Index)
        {
            T[] newArr = new T[arraySize];
            for (int i = 0; i < Index; i++)
            {
                newArr[i] = this.arr[i];
            }

            for (int i = Index + 1; i < index; i++)
            {
                newArr[i - 1] = this.arr[i];
            }

            this.arr = newArr;
            elementsInArray--;
        }

        public void Clear()
        {
            arr = new T[0];
            elementsInArray = 0;
        }

        public int IndexOf(T element)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(element))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private void AutoGrow()
        {
            arraySize *= 2;
            T[] newArr = new T[arraySize];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            this.arr = newArr;
        }

        public T Min()
        {
            T min = this.arr[0];
            for (int i = 0; i < arraySize; i++)
            {
                if (this.arr[i].CompareTo(min) < 0)
                {
                    min = this.arr[i];
                }
            } return min;
        }

        public T Max()
        {
            T max = this.arr[0];
            for (int i = 0; i < this.arraySize; i++)
            {
                if (this.arr[i].CompareTo(max) > 0)
                {
                    max = this.arr[i];
                }
            } return max;
        }

        public T this[int number]
        {
            get
            {
                // This is invoked when accessing Layout instances with the [ ].
                if (number >= 0 && number < elementsInArray)
                {
                    // Bounds were in range, so return the stored value.
                    return arr[number];
                }
                // Return an error string.
                throw new IndexOutOfRangeException();
            }
            set
            {
                // This is invoked when assigning to Layout instances with the [ ].
                if (number >= 0 && number < elementsInArray)
                {
                    // Assign to this element slot in the internal array.
                    arr[number] = value;
                }
                else throw new IndexOutOfRangeException();
            }
        }

        public override string ToString()
        {
            var text = new StringBuilder(arr.Length);
            for (int i = 0; i < elementsInArray; i++)
            {
                text.Append(arr[i] + ", ");
            }
            return text.ToString();
        }
    }
}
