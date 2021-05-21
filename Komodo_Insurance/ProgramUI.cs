using Komodo_Ins_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    public class ProgramUI
    {
        private readonly KomodoInsurance _repo = new KomodoInsurance();
        private Dictionary<>

        public void Run()
        {
            DictionarySeed();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n \n" +
                    "1. Add a badge \n" +
                    "2. Edit a badge \n" +
                    "3. List all badges \n" +
                    "4. Exit \n" +
                    "Select an option from 1-4");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        AddNewPermissions();
                        break;
                    case "2":
                    case "two":
                        EditBadgePermssions();
                        break;
                    case "3":
                    case "three":
                        ListAllBadgesPermissions();
                        break;
                    case "4":
                    case "four":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Enter valid selection");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void AddNewPermissions()
        {
            Console.Clear();
            Console.WriteLine("ADD NEW BADGE AND ASSIGN DOORS\n" +
                "1. Add a new badge \n" +
                "2. Add doors to new badge \n" +
                "3. Exit to Main Menu\n" +
                "Select an option from 1-3");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "1":
                case "one":
                    AddNewBadge();
                    break;
                case "2":
                case "two":
                    AddDoorsToBadge();
                    break;
                case "3":
                case "three":
                    Console.Clear();
                    Menu();
                    break;
                default:
                    Console.WriteLine("Enter valid selection");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

        public void AddNewBadge()
        {
            Console.WriteLine("What is the number on the badge:");
            int newBadgeID = Convert.ToInt32(Console.ReadLine());

            bool wasAdded = _repo.AddBadgeAssignment(newBadgeID);
            if (wasAdded == true)
            {
                Console.WriteLine("Your badge was added.");
            }
            else
            {
                Console.WriteLine("Selection was invalid, please try again.");
            }
            Console.ReadKey();
        }

        public void AddDoorsToBadge()
        {
            Console.WriteLine("What is the number on the badge: ");
            int newBadgeID = Convert.ToInt32(Console.ReadLine());
            bool wasAdded = true;

            //change add to AddDoorPermissions
            List<string> doors = new List<string>();

            while (wasAdded)
            {
                Console.WriteLine("Please type in one your selection at a time and select enter. \n" +
                "The Following Doors are available: \n" +
                "A1, A2, A3, A4, A5, A6, A7 \n" +
                "B1, B2, B3, B4 \n" +
                "C1, C2, C3, C4. \n" +
                "\n" +
                "When you are finished with your selection(s): type exit");

                doors.Add(Console.ReadLine());

                Dictionary < string, List<KomodoInsurance> allBadges = _repo.GetAllDetails();

                bool wasAdded = _repo.AddDoorPermissions(newBadgeID);

                //check to see if added
                Console.WriteLine("Item was added succesfully.  Press Enter to continue to Main Menu.");
                Console.ReadLine();
                Console.ReadKey();

                string exitToMenu = Console.ReadLine();

                if (exitToMenu.ToLower() == "exit")
                {
                    return false;
                }
            }
            //add new door
            newBadge.Doors = doors;
        }

        public void EditBadgePermissions()
        {
            Console.Clear();
            Console.WriteLine("What is the badge number to update?\n" +
                "If the number is not being updated at this time, please enter the same badge number in this line.");
            int changeBadgeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{changeBadgeID} currently has access to following doors" /*get information from dictionary/repo*/)".\n;" +
                "Please make a selection 1-2: " +
                "1. Add a door: \n" +
                "2. Remove a door: \n");

            string input = Console.ReadLine();
            switch (input.ToLower());
            {
                case "1":
                case "one":
                    RemoveDoorPermissions();
                break;
                case "2":
                case "two":
                    AddDoorPermissions();
                break;
                default:
                    Console.WriteLine("Sorry, invalid selection.");
                Console.ReadLine();
                Console.Clear();
                break;
            }

            public void RemoveDoorPermission()
            {
                Console.WriteLine("Which door would you like to remove?");
            }
        }


        public void ListAllBadges()
        {
            Console.Clear();
            Dictionary < string, List<KomodoInsurance> allBadges = _repo.GetAllDetails();
            //is there a padding style?
            Console.WriteLine($"KEY\n" +
                $"{BadgeID} \n" +
                $"Door Access: \n");

            foreach (KeyValuePair<string, List<KomodoInsurance>> kvp in allBadges)
            {
                Console.WriteLine($"{kvp.Key,-25} {string.Join(", ", kvp.Value)}");
            }
        }

        public void DictionarySeed()
        {
            KomodoInsurance exOne = new KomodoInsurance(12345, new List<string> { "A7" });
            KomodoInsurance exTwo = new KomodoInsurance(22345, new List<string> { "A1", "A4", "B1", "B2" });
            KomodoInsurance exThree = new KomodoInsurance(32345, new List<string> { "A4", "A5" });

            _repo.Add(new KeyValuePair<int,KomodoInsurance>(exOne);


        }
    }
}
