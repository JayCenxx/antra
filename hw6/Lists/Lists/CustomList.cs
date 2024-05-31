using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class CustomList <T>
    {
        private T[] list;
        private int dynamicArrayCount;
        CustomList()
        {
            this.dynamicArrayCount = 20;
            list = new T[this.dynamicArrayCount];
        }

        private void resize()
        {
            //drop the old one, increase size of arrayCount and create new a new one 

            this.dynamicArrayCount += this.dynamicArrayCount;
            T[] newList = new T[this.dynamicArrayCount];

            //list.Length mean the amount of element to copy
            Array.Copy(list, newList, list.Length);

            //drop the old one and assign to the new one, the old one ll be garbage collected
            this.list = newList;
        }
        public void Add (T element)
        {
            if (list.Length >= dynamicArrayCount)
            {
                resize();
            }
            else
            {

                list[list.Length] = element;
            }
        }

        public void setArrayCount(int size) {
            this.dynamicArrayCount = size;
        }
       
      
        T Remove(int index)
        {
            //is the array empty,
            if (this.list.Length == 0)
            {
                //end the method if empty array
                return default(T);
            }

            //is the index passed in index out of bound
            if(index<0 || index > this.list.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            //get the value to be deleted first 
            T delValue= this.list[index];

            // then we ll shift the element to the left 
            for(int i = index; i < this.list.Length - 1; i++)
            {
                this.list[i]=this.list[i+1];
            }

            return delValue;
        }

        public bool Contains(T desiredElement) {
            foreach(T item in this.list)
            {
                //iterate thr the arr, if found return true
                if (item.Equals(desiredElement))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            if (this.list.Length != 0)
            {
                this.list= new T[this.dynamicArrayCount];
            }
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > this.list.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            
            T[] newList = new T[this.list.Length + 1];

             
            for (int i = 0; i < index; i++)
            {
                newList[i] = this.list[i];
            }

           
            newList[index] = element;

         
            for (int i = index; i < this.list.Length; i++)
            {
                newList[i + 1] = this.list[i];
            }

           
            this.list = newList;
        }

        public T Find(int index)
        {
            if (index < 0 || index >= this.list.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            return this.list[index];
        }

        public void DeleteAt(int index)
        {
          
            if (index < 0 || index >= this.list.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            } 
            
            for (int i = index; i < this.list.Length - 1; i++)
            {
                this.list[i] = this.list[i + 1];
            }
             
            T[] newList = new T[this.list.Length - 1];
            Array.Copy(this.list, newList, newList.Length);
             
            this.list = newList;
        }

    }
}
