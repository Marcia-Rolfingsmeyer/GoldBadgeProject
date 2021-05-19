using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Project_Repo
{ 
    public class CafeItems
    {
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public decimal MealCost { get; set; }
        public int MealNumber { get; set; }

        public CafeItems() { }

        public CafeItems(string mealName, string mealDescription, string mealIngredients, decimal mealCost, int mealNumber)
        {
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealCost = mealCost;
            MealNumber = mealNumber;
        }
    }
}
