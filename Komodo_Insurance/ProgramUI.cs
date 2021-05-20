﻿using Komodo_Ins_Repo;
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
        public void Run()
        {
            //DictionarySeed();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Badge Menu \n" +
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
                        AddNewBadge();
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
                        keepRunning = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void AddNewPermissions()
        {
            Console.Clear();
            Console.WriteLine("What is the number on the badge:");
            int newBadgeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in all doors being  assigned and select enter. \n" +
                "The Following Doors are available: \n" +
                "A1, A2, A3, A4, B1, B2, B3, C1, C2, C3, C4, C5, C6");
            string newBadgeDoor = Console.ReadLine();

            //bool wasAdded = _repo.GetNewPermissions(newBadgeID);
            //if (wasAdded)
            //{
            //    Console.WriteLine("The new Badge was added correctly!");
            //}
            //else
            //{
            //    Console.WriteLine("Could not add badge.");
            //}
        }

        public void EditBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the badge number to update?\n" +
                "If the number is not being updated at this time, please enter the same badge number in this line.");
            int changeBadgeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{changeBadgeID} has access to following doors" /*get information from dictionary/repo*/)".\n;" +
                "Please make a selection 1-2: " +
                "1. Add a door: \n" +
                "2. Remove a door: \n");


            string input = Console.ReadLine();
            switch(input.ToLower());
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
                string doorToRemove = (Console.ReadLine().ToLower());
                
            if(Enum.IsDefined(typeof(KIDoors), doorToRemove))
                {
                    KIDoors removeDoor = (Door)Enum.Parse()
                }
            else
            {
                Console.WriteLine($"{removeDoor} is not assigned to {BadgeID});
            }



        }
        
        public void ListAllBadges()
        {
        }
    }
}
