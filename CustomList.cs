using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class CustomList<T>
    {
        private T[] array;
        private int count;
        private  int capacity = 4;

        public int Capacity
        {
            get
            {
                return capacity;
            }   
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            array = new T[Capacity];
            count = 0;
        }

        public CustomList(int _capacity)
        {
            if(_capacity < 0) { throw new Exception(); }
            array = new T[_capacity];
            count = 0;
            capacity = _capacity;
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                Array.Resize(ref array, count * 2);
                capacity *= 2;
            }
            array[count++] = item;
        }

        public bool Exists(Predicate<T> match)
        {
            if (match == null)
                throw new Exception();

            for (int i = 0; i < count; i++)
            {
                if (match(array[i]))
                    return true;
            }
            return false;
        }


        public T Find(Predicate<T> match)
        {
            if (match == null) throw new Exception();

            for (int i = 0; i < count; i++)
            {
                if (match.Invoke(array[i]))
                    return array[i];
            }
            return default;
        }

        public CustomList<T> FindAll(Predicate<T> match)
        {
            if (match == null) throw new Exception("match Function Must Be Not Null");

            CustomList<T> results = new CustomList<T>();
            for (int i = 0; i < count; i++)
            {
                if (match.Invoke(array[i]))
                    results.Add(array[i]);
            }
            return results;
        }

        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            if (match == null || startIndex < 0 || startIndex > this.count || count < 0 || startIndex + count > this.count)
                throw new Exception("Invalid Data");

            for (int i = startIndex ; i < startIndex + count; i++)
            {
                if (match.Invoke(array[i]))
                    return i;
            }
            return -1;
        }

        public int FindIndex(int startIndex, Predicate<T> match)
        {
            if (match == null || startIndex < 0 || startIndex>count)
                throw new Exception("Invalid Data");

            return FindIndex(startIndex, count - startIndex, match);
        }

        public int FindIndex(Predicate<T> match)
        {
            if (match == null) throw new Exception("match Must Be Not Null");

            return FindIndex(0, count, match);
        }
 
        public T FindLast(Predicate<T> match)
        {
            if (match == null)
                throw new Exception("match Function Must Be Not Null");

            for (int i = count - 1; i >= 0; i--)
            {
                if (match(array[i]))
                    return array[i];
            }
            return default;
        }
        public int FindLastIndex(Predicate<T> match)
        {
            if (match == null)
                throw new Exception("Invalid Predicate");

            return FindLastIndex(count - 1, count, match);
        }

        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
            if (match == null || startIndex<0)
                throw new Exception("Invalid Data");

            return FindLastIndex(startIndex, startIndex + 1, match);
        }

        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
            if (match == null || count < 0 || match == null || startIndex - count <= -1) throw new Exception("Invalid");
            if (this.count == 0)
            {
                    throw new Exception("List Is Empty!!!");
            }
            else if (startIndex < 0 || startIndex >= this.count)
                throw new IndexOutOfRangeException();

            int endIndex = startIndex - count;
            for (int i = startIndex ; i > endIndex; i--)
            {
                if (match(array[i]))
                    return i;
            }
            return -1;
        }
       
        public void ForEach(Action<T> action)
        {
            if (action == null) throw new Exception("Action Must be Not Null ");

            for (int i = 0; i < count; i++)
            {
                action(array[i]);
            }
        }

        public bool TrueForAll(Predicate<T> match)
        {
            if (match == null) throw new Exception("Invalid Data");

            for (int i = 0; i < count; i++)
            {
                if (!match(array[i]))
                    return false;
            }
            return true;
        }
    }

}
