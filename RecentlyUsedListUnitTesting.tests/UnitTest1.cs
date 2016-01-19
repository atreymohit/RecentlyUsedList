using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecentlyUsedListImplementation;
namespace RecentlyUsedListUnitTesting.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnZeroWhenCountItemsIsCalledForInitialList()
        {
            RecentlyUsedList<int> ListObject = new RecentlyUsedList<int>(5);

            int countItems=ListObject.CountItems();

            Assert.AreEqual(0, countItems, "Initially The list is not Empty.");
        }

        [TestMethod]
        public void ShouldReturn_c_When_c_IsAddedLast()
        {
            RecentlyUsedList<string> ListObject = new RecentlyUsedList<string>(5);

            ListObject.AddItem("Mohit");
            ListObject.AddItem("Raj");
            ListObject.AddItem("Atrey");

            var item = ListObject[0];

            Assert.AreEqual("Atrey", item, "The most recently added item is not the first item.");
        }

        [TestMethod]
        public void ShouldReturnEightWhenItemAtIndexOneIsCalled_AndEightShouldBeTheFirstElement()
        {
            RecentlyUsedList<int> ListObject = new RecentlyUsedList<int>(5);

            ListObject.AddItem(12);
            ListObject.AddItem(8);
            ListObject.AddItem(5);

            var item = ListObject[1];

            Assert.AreEqual(8, item, "8 is not at the first index.");
            Assert.AreEqual(8, ListObject[0], "8 is not the first item.");
        }

        [TestMethod]
        public void ShouldReturnThreeWhenCountItemsIsCalledAfterEightIsAddedAgainAndEightShouldBeTheFirstElement()
        {
            RecentlyUsedList<char> ListObject = new RecentlyUsedList<char>(5);

            ListObject.AddItem('m');
            ListObject.AddItem('a');
            ListObject.AddItem('c');
            ListObject.AddItem('a');

            int countItems = ListObject.CountItems();

            Assert.AreEqual(3, countItems, "The size of list is not Three");
            Assert.AreEqual('a', ListObject[0], "a is not the first item.");
        }

        [TestMethod]
        public void ShouldReturnAtreyAsFirstItemAndEightAsLastItemIfAtreyIsAddedAfterListSizeIsFull()
        {
            RecentlyUsedList<int> ListObject = new RecentlyUsedList<int>(5);

            ListObject.AddItem(11);
            ListObject.AddItem(8);
            ListObject.AddItem(6);
            ListObject.AddItem(4);
            ListObject.AddItem(13);
            ListObject.AddItem(32);

            var firstItem = ListObject[0];
            var lastItem = ListObject[4];
            int countItems = ListObject.CountItems();

            Assert.AreEqual(32,firstItem , "The First item is not 32.");
            Assert.AreEqual(8, lastItem, "The last item is not 8.");
            Assert.AreEqual(5, countItems, "The size of list is not five");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldGiveArgumentOutOfRangeExceptionWhenMinusOneIndexedElementIsSearched()
        {
            RecentlyUsedList<int> ListObject = new RecentlyUsedList<int>(5);

            ListObject.AddItem(12);
            ListObject.AddItem(8);
            ListObject.AddItem(32);

            var item = ListObject[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldGiveArgumentOutOfRangeExceptionWhenThirdIndexedElementIsSearchedOfThreeSizeList()
        {
            RecentlyUsedList<int> ListObject = new RecentlyUsedList<int>(5);

            ListObject.AddItem(12);
            ListObject.AddItem(8);
            ListObject.AddItem(32);

            var item = ListObject[3];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldGiveArgumentOutOfRangeExceptionWhenZeroIndexedItemIsSearchedForEmptyList()
        {
            RecentlyUsedList<int> ListObject = new RecentlyUsedList<int>(5);
            var item = ListObject[0];
        }

        [TestMethod]
        public void ShouldReturnMohitWhenFirstIndexedEmployeeObjectNameIsCalled()
        {
            RecentlyUsedList<Employee> ListObject = new RecentlyUsedList<Employee>(5);
            Employee emp1 = new Employee();
            emp1.name = "Atrey";
            Employee emp2 = new Employee();
            emp2.name = "Mohit";
            Employee emp3 = new Employee();
            emp3.name = "Raj";
            ListObject.AddItem(emp1);
            ListObject.AddItem(emp2);
            ListObject.AddItem(emp3);
            
            Assert.AreEqual("Mohit", ListObject[1].name, "Mohit is not at the First Index.");
        }

    }
    public class Employee
    {
        public string name;
    }
}
