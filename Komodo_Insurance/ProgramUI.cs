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
        private readonly KomodoInsRepo _repo = new KomodoInsRepo();

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
                        EditBadgePermissions();
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
            Console.WriteLine("What is the number on the badge:");
            int newBadgeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in one selection one at a time. \n" +
            "The Following Doors are available: \n" +
            "A1, A2, A3, A4, A5, A6, A7 \n" +
            "B1, B2, B3, B4 \n" +
            "C1, C2, C3, C4. \n\n" +
            "Press x to exit. \n");

            List<string> doors = new List<string>();
            doors.Add(Console.ReadLine());

            bool runUntilDone = true;
            while (runUntilDone)
            {
                Console.WriteLine("Any more doors y/n? \n");
                char inputKey = Console.ReadKey().KeyChar;

                if (inputKey == 'y')
                {
                    Console.WriteLine("Type your selection.");
                    doors.Add(Console.ReadLine());
                }
                else if (inputKey == 'n')
                {
                    runUntilDone = false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                    Console.ReadKey();
                }
            }
            bool wasAdded = _repo.AddNewPermissions(newBadgeID, doors);
            Console.WriteLine($"Your badge {newBadgeID} and doors {doors} were added. \n" +
                $"Press any key to go back to the menu.");
            Console.ReadKey();
            Menu();
        }

        public void EditBadgePermissions()
        {
            Console.Clear();
            Console.WriteLine("Type in the badge number to update door access?");
            int readBadgeID = Convert.ToInt32(Console.ReadLine());
            KomodoInsurance badge = _repo.GetDetailsByBadgeID();

            Console.WriteLine($"{readBadgeID} currently has access to following doors {badge.Doors}) \n" +
                "Please make a selection 1-2:\n " +
                "1. Add a door: \n" +
                "2. Remove a door: \n");

            string input = Console.ReadLine();
            switch (input.ToLower())
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
                    Console.WriteLine("Sorry, invalid selection. Try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

        public void RemoveDoorPermissions()
        {
            Console.WriteLine("Which door would you like to remove?");
            string removeDoor = Console.ReadLine().ToLower();
            KomodoInsurance.Doors.Remove(removeDoor);
            Console.WriteLine($"Door{removeDoor} was removed from.");
        }

        public void AddDoorPermissions()
        {
            Console.WriteLine("Which door would you like to add?");
            string addDoor = Console.ReadLine().ToLower();
            KomodoInsRepo.doors.Add(addDoor);
            Console.WriteLine($"Door {addDoor} was added.");
        }

        public void ListAllBadgesPermissions()
        {
            Console.Clear();
            Dictionary<int, List<string>> allDetails = _repo.GetAllDetails();
            foreach (int badgeID in allDetails.Keys)
            {
                string doors = string.Join(",", allDetails[badgeID]);
                Console.WriteLine($"Badge ID: {badgeID - 10} Access to Doors: {doors}");
            }
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        public void DictionarySeed()
        {
            KomodoInsurance exOne = new KomodoInsurance(12345, new List<string> { "A7" });
            KomodoInsurance exTwo = new KomodoInsurance(22345, new List<string> { "A1", "A4", "B1", "B2" });
            KomodoInsurance exThree = new KomodoInsurance(32345, new List<string> { "A4", "A5" });

            _repo.AddNewPermissions(exOne);
            _repo.AddNewPermissions(exTwo);
        }
    }
}
