using GenericCollectionsTask.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsTask.Models
{
    internal class CustomList<T>
    {
        public T[] arr = new T[0];


        public void Add(T inputValue)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = inputValue;
        }

        public void Remove(T inputValue)
        {
            bool isExist = true;
            T[] arrCopy = new T[0];
            foreach (T item in arr)
            {
                if (EqualityComparer<T>.Default.Equals(inputValue, item))
                {
                    isExist = false;
                    continue;
                }
                
                Array.Resize(ref arrCopy, arrCopy.Length + 1);
                arrCopy[arrCopy.Length - 1] = item;
            }

            if (isExist)
            {
                throw new NotFoundException("Not founded element");
            }


            arr = arrCopy;
        }

        public void Clear()
        {
            T[] arrCopy = new T[0];
            arr = arrCopy;
        }

        public bool Contains(T inputValue)
        {
            foreach (T item in arr)
            {
                if (EqualityComparer<T>.Default.Equals(inputValue, item))
                {
                    return true;
                }
            }

            return false;
        }


        public int Count()
        {
            int count = 0;
            foreach (T item in arr)
            {
                count++;
            }

            return count;
        }
    }
}
