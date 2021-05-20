using Claim_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim_Project
{
    public class ProgramUI
    {
        private readonly ClaimRepository _repo = new ClaimRepository();

        public void Run()
        {
            SeedClaims();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine(
                    "Select a menu option: \n" +
                    "1. See all claims. \n" +
                    "2. Take care of next claim. \n" +
                    "3. Enter new claim. \n" +
                    "4. Exit. \n" +
                    "Please Enter a Number 1-4: \n");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        ViewAllClaims();
                        break;
                    case "2":
                    case "two":
                        ViewNextClaim();
                        break;
                    case "3":
                    case "three":
                        AddNewClaim();
                        break;
                    case "4":
                    case "four":
                        keepRunning = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void ViewAllClaims()
        {
            Console.WriteLine(_repo.GetAllClaims());
        }

        private void ViewNextClaim()
        {
            bool nextClaimAvailable = true;
            while (nextClaimAvailable)
            {
                Console.Clear();
                _repo.GetNextClaim();
                Console.WriteLine
                    ("Select a menu option: \n" +
                    "1. Delete completed claim and go to next claim. \n" +
                    "2. Claim not completed, exit to main menu.\n" +
                    "Please select option 1 or 2.");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        _repo.DeleteClaim();
                        break;
                    case "2":
                    case "two":
                        nextClaimAvailable = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void AddNewClaim()
        {
            Console.Clear();
            Claims newClaim = new Claims();

            Console.WriteLine("Please enter the Claim ID Number?");
            string claimIDAsString = Console.ReadLine();
            int claimIDAsInt = Convert.ToInt32(claimIDAsString);
            newClaim.ClaimID = claimIDAsInt;

            Console.WriteLine("Select the following: \n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n" +
                "Please select 1-3.");
            string typeAsString = Console.ReadLine();
            int typeAsInt = Convert.ToInt32(typeAsString);
            newClaim.TypeOfClaim = (ClaimType)typeAsInt;

            Console.WriteLine("Please enter a descritpion: ");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Please enter the claim amount in decimal form (example: 100.59)");
            string claimAmountAsString = Console.ReadLine();
            decimal claimAmountAsDecimal = Convert.ToDecimal(claimAmountAsString);
            newClaim.ClaimAmount = claimAmountAsDecimal;

            Console.WriteLine("Enter the date that the incident occurred - please use the following formate:\n" +
                " year/month/day\n" +
                " (example: 2021/01/31)");
            string incidentAsString = Console.ReadLine();
            var incidentDT = DateTime.Parse(incidentAsString);
            newClaim.DateOfIncident = incidentDT;

            Console.WriteLine("Enter the date that the claim was made - please use the following formate:\n" +
    " year/month/day\n" +
    " (example: 2021/01/31)");
            string claimDTAsString = Console.ReadLine();
            var claimDT = DateTime.Parse(claimDTAsString);
            newClaim.DateOfIncident = claimDT;
        }

        private void SeedClaims()
        {
            Claims exOne = new Claims(1, ClaimType.Car, "Car accident on 465", 400.00m, new DateTime(2021/04/25), new DateTime(2021/04/25));
            Claims exTwo = new Claims(2, ClaimType.Home, "House fire in kitchen.", 4000.00m, new DateTime (2021, 04, 11), new DateTime(2021, 04, 12));
            Claims exThree = new Claims(3, ClaimType.Theft, "Stolen Pancakes", 4.00m, new DateTime(2021/03/27), new DateTime(2021/05/01));

            _repo.AddClaim(exOne);
            _repo.AddClaim(exTwo);
            _repo.AddClaim(exThree);
        }
    }
}

