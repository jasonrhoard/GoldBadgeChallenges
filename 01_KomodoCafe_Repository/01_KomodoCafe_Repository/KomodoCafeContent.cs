using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Repository
{
    public class KomodoCafeContent
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public double MealPrice { get; set; }

        public KomodoCafeContent() { }
        public KomodoCafeContent(int mealNumber, string mealName, string mealDescrption, string mealIngredients, double mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescrption;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }
    }
}
