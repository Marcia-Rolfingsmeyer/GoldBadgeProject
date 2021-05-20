using Claim_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClaimProject
{
    [TestClass]
    public class ClaimTest
    {
        private readonly ClaimRepository _repo = new ClaimRepository();

        [TestMethod]
        public void GetAllClaimsTest()
        {
            SeedContentList();

            Queue<Claims> allClaims = _repo.GetAllClaims();

            Assert.AreEqual(2, allClaims.Count);
        }
       
        [TestMethod]
        public void DeleteClaimTest()
        {
            Claims deleteClaim = new Claims(12, ClaimType.Car, "Client vehicle hit while parked", 8540.68m, new DateTime(2021 / 05 / 09), new DateTime(2021 / 05 / 09));

            bool wasDeleted = _repo.AddClaim(deleteClaim);

            Assert.IsTrue(wasDeleted);
        }

        [TestMethod]
        public void AddClaimsTest()
        { 
            Claims newClaim = new Claims(12, ClaimType.Car, "Client vehicle hit while parked", 8540.68m, new DateTime(2021 / 05 / 09), new DateTime(2021 / 05 / 09));

            bool wasAdded = _repo.AddClaim(newClaim);

            Assert.IsTrue(wasAdded);
        }

        public void SeedContentList()
        {
            Claims testExample = new Claims(1, ClaimType.Theft, "Bags of It Equipment stolen from vehcile", 4320.00m, new DateTime(2021, 01, 29), new DateTime(2021, 02, 01));

            Claims testExample2 = new Claims(2, ClaimType.Home, "Tree Damaged/Replacement from car accident", 1050.00m, new DateTime(2021, 03, 01), new DateTime(2021, 04, 20));

            _repo.AddClaim(testExample);
            _repo.AddClaim(testExample2);
        }
    }
}
