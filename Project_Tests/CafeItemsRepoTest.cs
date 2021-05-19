using Cafe_Project_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Cafe_Items_Test
{
    [TestClass]
    public class CafeItemsRepoTest
    {
        [TestMethod]
        public void AddtoDirectory()
        {
            CafeItems items = new CafeItems();
            CafeItemsRepo repository = new CafeItemsRepo();

            bool addResult = repository.AddToCafeItemDirectory(items);

            Assert.IsTrue(addResult);
        }


        [TestMethod]
        public void GetDirectory()
        {
            CafeItems items = new CafeItems();
            CafeItemsRepo repository = new CafeItemsRepo();
            repository.AddToCafeItemDirectory(items);

            List<CafeItems> directory = repository.AddCafeItems();

            bool directoryHasCafeItems = directory.Contains(items);

            Assert.IsTrue(directoryHasCafeItems);
        }

        private CafeItems _items;
        private CafeItemsRepo _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new CafeItemsRepo();
            _items = new CafeItems("Simple Burger", "1/4 Burger Patty, Broche Bun, Seasoned Fries, and Regular Drink", "Lettuce, Tomatoe, Onion, Pickle, Mustard, Ketchup, Mayo", 9.99m, 5);
            _repo.AddToCafeItemDirectory(_items);
        }

        [TestMethod]
        public void GetCafeItemsByMealName()
        {
            CafeItems displayResult = _repo.AddCafeItemsMealName("Simple Burger");

            Assert.AreEqual(_items, displayResult);
        }

        [TestMethod]
        public void UpdateExistingCafeItems()
        {
            _repo.UpdateExistingCafeItems("Simple Burger", new CafeItems("Simple Burger 2", "2 patties with all the trimmings, seasoned fries, and regular drink", "2 1/4 beef patties, broche bun, cheddar cheese, lettuce, tomatoe, onion, pickle, mustard, mayo, ketchup", 12.99m, 6));

            Assert.AreEqual(_items.MealName, "Simple Burger 2");
        }

        [TestMethod]
        public void DeleteExisitingCafeItems()
        {
            bool wasDeleted = _repo.DeleteCafeItems("Simple Burger");

            Assert.IsTrue(wasDeleted);
        }
    }
}

