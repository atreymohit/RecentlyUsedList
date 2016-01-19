using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentlyUsedListImplementation
{
    public class RecentlyUsedList<T>
    {

        public int Capacity { get; set; }

        public RecentlyUsedList()
        {
            Capacity = 0;
        }

        public RecentlyUsedList(int capacity)
        {
            Capacity = capacity;
        }


        public List<T> MyList = new List<T>();

        public T this[int i]
        {
            get
            {
                return SearchByIndexAndRearrange(i);
            }
        }

        public void ShowList()
        {
            foreach (T item in MyList)
            {
                Console.WriteLine(item);
            }
        }

        public void AddItem(T obj)
        {
            int index = MyList.IndexOf(obj);
            if (index == -1)
            {
                if(MyList.Count>=Capacity)
                {
                    MyList.RemoveAt(MyList.Count - 1);
                }
                MyList.Insert(0, obj);
            }
            else
            {
                SearchByIndexAndRearrange(index);
            }
        }

        private T SearchByIndexAndRearrange(int index)
        {
            var item = MyList.ElementAt(index);
            MyList.Remove(item);
            AddItem(item);
            return item;
        }

        public int CountItems()
        {
            return MyList.Count;
        }
    }
}
