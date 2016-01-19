using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentlyUsedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecentlyUsedList rul = new RecentlyUsedList();
            //rul.AddItem("Mohit");
            //rul.AddItem(1);
            //rul.AddItem('c');
            //rul.showList();
            //Console.WriteLine(rul.SearchByIndex(1));
            //rul.AddItem(1);
            //rul.showList();
            RecentlyUsedList<int> ListObject = new RecentlyUsedList<int>(5);

            ListObject.AddItem(4);
            ListObject.AddItem(8);
            ListObject.AddItem(3);
            ListObject.AddItem(4);
            ListObject.AddItem(2);
            ListObject.AddItem(1);

            ListObject.ShowList();
            Console.ReadKey();
        }
    }
}
