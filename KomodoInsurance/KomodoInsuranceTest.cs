using Komodo_Ins_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoInsurance
{
    [TestClass]
    public class KomodoInsuranceTest
    {
        private readonly KomodoInsRepo _repo = new KomodoInsRepo();

        KomodoInsurance items = new KomodoInsurance();
        KomodoInsRepo repo = new KomodoInsRepo():

        [TestMethod]
        public void AddNewPermissionsTest()
        {
            KomodoInsurance items = new KomodoInsurance();
            KomodoInsRepo repo = new KomodoInsRepo():
            bool addBadge = _repo.AddNewPermissions(items);

            Assert.AreEqual(addBadge);
                //(3456, new List<string> { "A2", "B4", "C1" });
        }

        [TestMethod]
        public void UpdateExistingBadgeTest()
        {
            string updateDoors = "C2";
            _repo.UpdateExistingBadge(5432, updateDoors);
            Assert.AreEqual("C2", items.Doors.Count);
        }

        [TestMethod]
        public void GetAllDetailsTest()
        {
            _repo.AddNewPermissions(items);
            Dictionary<int, List<string>> exampleDictionary = _repo.GetAllDetails();
            Assert.AreEqual(2, exampleDictionary);
        }

        [TestMethod]
        public void RemoveADoorTest()
        {
            KomodoInsurance.Doors.Remove(removeDoor);

            bool wasDeleted = _repo.RemoveADoor();

            Assert.IsTrue(wasDeleted);
        }
    }
}
