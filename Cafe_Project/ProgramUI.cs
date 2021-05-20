using Cafe_Project_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Project
{
    public class ProgramUI
    {
        private readonly CafeItemsRepo _repo = new CafeItemsRepo();

        public void Run()
        {
            SeedCafeItemsList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine(
                    "Select a menu option: \n" +
                    "1. Create new menu item. \n" +
                    "2. View all menu items. \n" +
                    "3. Update menu item. \n" +
                    "4. Delect menu item. \n" +
                    "5. Exit\n" +
                    "Please Enter a Number 1 - 5: \n");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        CreateNewCafeItems();
                        break;
                    case "2":
                    case "two":
                        ViewCafeItems();
                        break;
                    case "3":
                    case "three":
                        UpdateCafeItems();
                        break;
                    case "4":
                    case "four":
                        DeleteExistingItems();
                        break;
                    case "5":
                    case "five":
                        keepRunning = false;
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewCafeItems()
        {
            Console.Clear();
            CafeItems newCafeItems = new CafeItems();

            Console.WriteLine("What is your meal name?");
            newCafeItems.MealName = Console.ReadLine();

            Console.WriteLine("What is included with this meal?");
            newCafeItems.MealDescription = Console.ReadLine();

            Console.WriteLine("What are the ingredients in this meal?");
            newCafeItems.MealIngredients = Console.ReadLine();

            Console.WriteLine("How much does this meal cost? (only use numbers with decimal point)");
            string MealCostAsString = Console.ReadLine();
            decimal MealCostAsDecimal = Convert.ToDecimal(MealCostAsString);
            newCafeItems.MealCost = MealCostAsDecimal;

            Console.WriteLine("What is the Meal Number for this meal?");
            string mealNumberAsString = Console.ReadLine();
            int mealNumberAsInt = Convert.ToInt32(mealNumberAsString);
            newCafeItems.MealCost = mealNumberAsInt;

            bool wasAddedCorrectly = _repo.AddToCafeItemDirectory(newCafeItems);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The new Meal was added correctly!");
            }
            else
            {
                Console.WriteLine("Could not add items.");
            }
        }

        private void ViewCafeItems()
        {
            Console.Clear();
            List<CafeItems> allCafeItems = _repo.ShowAllCafeItems();
            foreach (CafeItems items in allCafeItems)
            {
                Console.WriteLine
                    ($"Meal Name: {items.MealName}   \n" + $"Meal Description: {items.MealDescription}     \n" + $"Meal Ingredients: {items.MealIngredients}  \n" + $"Meal Cost: {items.MealCost}  \n" + $"Meal Number: {items.MealNumber}  \n");
            }
        }

        private void UpdateCafeItems()
        {
            Console.Clear();
            ViewCafeItems();
            Console.WriteLine("Enter the item you would like to update.");

            string oldCafeItems = Console.ReadLine();

            CafeItems newItems = new CafeItems();

            Console.WriteLine("Enter the new name of the cafe items.");
            newItems.MealName = Console.ReadLine();

            Console.WriteLine("Enter the new description of the cafe item.");
            newItems.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter the new Ingredients of the cafe item.");
            newItems.MealIngredients = Console.ReadLine();

            Console.WriteLine("Enter the new Cost of the cafe item.");
            string mealCostAsString = Console.ReadLine();
            decimal mealCostAsDecimal = Convert.ToDecimal(mealCostAsString);
            newItems.MealCost = mealCostAsDecimal;

            Console.WriteLine("Enter the new Meal Number of the cafe item.");
            string mealNumberAsString = Console.ReadLine();
            int mealNumberAsInt = Convert.ToInt32(mealNumberAsString);
            newItems.MealCost = mealNumberAsInt;

            bool wasUpdated = _repo.UpdateExistingCafeItems(oldCafeItems, newItems);
            if (wasUpdated)
            {
                Console.WriteLine("The cafe item was added successfully.");
            }
            else
            {
                Console.WriteLine("No cafe item was not updated successfully.");
            }
        }

        private void DeleteExistingItems()
        {
            Console.Clear();
            ViewCafeItems();

            Console.WriteLine("Enter the Meal Name for the items you want to delete.");

            bool wasDeleted = _repo.DeleteCafeItems(Console.ReadLine());
            if (wasDeleted)
            {
                Console.WriteLine("Your content was successfully deleted!");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
            }
        }

        private void SeedCafeItemsList()
        {
            CafeItems theTitus = new CafeItems("BigBoy Burger", "Triple 1/4lb Patties on a Borche Bun with special sauce with all the trimings, a side of seasoned fries and a regular drink", "Bun, Lettuce, Tomatoe, Pickle, Cheddar Cheese", 15.99m, 1);
            CafeItems theGuerin = new CafeItems("Burger with Cheese", "1/4 lb Burger on sourdough bread grilled with cheddar, munster, and provolone cheese with thousand island dressing all the trimings, a side of seasoned fries and a regular drink", "Bun, Lettuce, Tomatoe, Pickle, Cheddar Cheese", 11.99m, 2);
            CafeItems theChickenSue = new CafeItems("Chicken Sandwich", "A Chicken Patty on a Kaiser Roll, a side of seasoned fries and a regular drink", "1 chicken patty, 1 Bun, provolone cheese, Lettuce, mayo", 10.99m, 3);
            CafeItems theMarcia = new CafeItems("Spicy Burger", "Single Patty on a Pretzel Bun with sauce with a side of seasoned fries and a regular drink", "Bun, Lettuce, Tomatoe, Pickle, Cheddar Cheese", 9.99m, 4);
            _repo.AddToCafeItemDirectory(theTitus);
            _repo.AddToCafeItemDirectory(theGuerin);
            _repo.AddToCafeItemDirectory(theChickenSue);
            _repo.AddToCafeItemDirectory(theMarcia);
        }
    }
}
