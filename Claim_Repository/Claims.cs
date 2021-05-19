using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim_Repository
{
    public enum ClaimType { Car, Home, Theft }

    //    Komodo allows an insurance claim to be made up to 30 days after an incident took place.If the claim is not in the proper time limit, it is not valid.

    public class Claims
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim {get; set;}
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        //{
        //    get
        //    {
        //      c = (DateOfIncident - DateOfClaim)
        //      bool isValid = (c < 31) ? true : false; 
        //    }
        //}

        public Claims() { }

        public Claims(int claimID, ClaimType typeOfClaim, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
