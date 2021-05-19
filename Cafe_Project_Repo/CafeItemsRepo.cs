using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Project_Repo
{
    public class CafeItemsRepo
    {
        private readonly List<CafeItems> _cafeItemsDirectory = new List<CafeItems>();

        public bool AddToCafeItemDirectory(CafeItems newItems)
        {
            int startingCount = _cafeItemsDirectory.Count;
            _cafeItemsDirectory.Add(newItems);
            bool wasAdded = _cafeItemsDirectory.Count > startingCount;
            return wasAdded;
        }

        public List<CafeItems> ShowAllCafeItems()
        {
            return _cafeItemsDirectory;
        }
        public CafeItems AddCafeItemsMealName(string newMealName)
        {
            foreach (CafeItems item in _cafeItemsDirectory)
            {
                if (item.MealName.ToLower() == newMealName.ToLower())
                {
                    return (CafeItems)item;
                }
            }
            return null;
        }

        public CafeItems AddCafeItemsMealDescription(string mealDescription)
        {
            foreach (CafeItems item in _cafeItemsDirectory)
            {
                if (item.MealDescription.ToLower() == mealDescription.ToLower())
                {
                    return item;
                }
            }
            return null;
        }

        public CafeItems AddCafeItemsMealIngredients(string mealIngredients)
        {
            foreach (CafeItems item in _cafeItemsDirectory)
            {
                if (item.MealIngredients.ToLower() == mealIngredients.ToLower())
                {
                    return item;
                }
            }
            return null;
        }

        public CafeItems AddCafeItemsMealCost(decimal mealCost)
        {
            foreach (CafeItems item in _cafeItemsDirectory)
            {
                if (item.MealCost == mealCost)
                {
                    return item;
                }
            }
            return null;
        }

        public CafeItems AddCafeItemsMealNumber(int mealNumber)
        {
            foreach (CafeItems item in _cafeItemsDirectory)
            {
                if (item.MealNumber == mealNumber)
                {
                    return item;
                }
            }
            return null;
        }

        public bool UpdateExistingCafeItems(string originalMealName, CafeItems newItemsValues)
        {
            CafeItems oldItems = AddCafeItemsMealName(originalMealName);
            if (oldItems != null)
            {
                oldItems.MealName = newItemsValues.MealName;
                oldItems.MealDescription = newItemsValues.MealDescription;
                oldItems.MealCost = newItemsValues.MealCost;
                oldItems.MealNumber = newItemsValues.MealNumber;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCafeItems(string mealNameToDelete)
        {
            CafeItems cafeItemToDelete = AddCafeItemsMealName(mealNameToDelete);
            if (cafeItemToDelete == null)
            {
                return false;
            }
            else
            {
                _cafeItemsDirectory.Remove(cafeItemToDelete);
                return true;
            }

        }
    }
}

