using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
     public class CustomStack <T>
    {
        private List<T> list;

        CustomStack()
        {
            list = new List<T>();
        }
        CustomStack(int size)
        {
            list = new List<T>(size);
        }

        public void Push(T data)
        {
            list.Add(data);
        }
        public T Pop()
        {
            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("Cannot pop from an empty list.");
            }
             
            T value = this.list[this.list.Count - 1];
             
            this.list.RemoveAt(this.list.Count - 1);
             
            return value;
        }

        public int Count()
        {
            return this.list.Count;
        }

    }
}
