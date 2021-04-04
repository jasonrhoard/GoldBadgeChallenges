using _01_KomodoCafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _01_KomodoCafe_Console
{
    class ProgramUI
    {
        private MenuContentRepository _contentRepo = new MenuContentRepository();

        public void Run()
        {
            SeedMenu();
            Menu();
        }

        private void Menu()
        {
            bool programRunning = true;
            while (programRunning)
            {
                Console.WriteLine("Welcome to...\n"+
                    "Komodo Cafe ----- K-o-m-o-d-o- C-a-f-e- ----- Komodo Cafe");
                Console.WriteLine("\n" +
                    "Please select an option number (1, 2 or 3):\n" +
                    "1. Add Menu Items\n" +
                    "2. Delete Menu Items\n" +
                    "3. See All Items\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddNewItems();
                        break;

                    case "2":
                        DeleteExistingMenuItems();
                        break;

                    case "3":
                        SeeAllItems();
                        break;
                    default:
                        Console.WriteLine("Please enter 1, 2, or 3:");
                        break;
                }
            }
        }

        private void AddNewItems()
        {
            KomodoCafeContent newItems = new KomodoCafeContent();

            Console.WriteLine("Please enter the menu item number:");
            string mealNumberString = Console.ReadLine();
            newItems.MealNumber = int.Parse(mealNumberString);

            Console.WriteLine("Please enter the meal name:");
            newItems.MealName = Console.ReadLine();

            Console.WriteLine("Please enter the meal description:");
            newItems.MealDescription = Console.ReadLine();

            Console.WriteLine("Please enter the meal ingredients:");
            newItems.MealIngredients = Console.ReadLine();

            Console.WriteLine("Please enter the meal price:");
            newItems.MealPrice = Convert.ToDouble(Console.ReadLine());
            //string mealPriceAsString = Console.ReadLine();
            //newItems.MealPrice = double.Parse(mealPriceAsString);

            _contentRepo.AddMenuItems(newItems);

        }

        private void DeleteExistingMenuItems()
        {
            Console.Clear();

            SeeAllItems();
            
            Console.WriteLine("Please type the meal name you would like to delete (HumCar, Cheesers,  etc.)");
            string input = Console.ReadLine();

           bool wasDeleted =  _contentRepo.DeleteMenuItems(input);
            if (wasDeleted)
            {
                Console.WriteLine("Menu item deleted!");

            }
            else
            {
                Console.WriteLine("Menu item could not be deleted");
            }
        }
        private void SeeAllItems()
        {
            Console.Clear();
            List<KomodoCafeContent> listOfItems = _contentRepo.GetMenuItems();
            
            foreach(KomodoCafeContent item in listOfItems)
            {
                Console.WriteLine($"Number:{item.MealNumber}\n"+ $"Name: {item.MealName}\n"+ $"Description: {item.MealDescription}\n"+ $"Ingredients: {item.MealIngredients}\n"+ $"Price $ {item.MealPrice}\n");
            }

            
        }

        private void SeedMenu()
        {
            KomodoCafeContent itemOne = new KomodoCafeContent(1, "HumCar", "Hummus and Baby Carrots", "Hummus, Baby Carrots", 2.99);
            KomodoCafeContent itemTwo = new KomodoCafeContent(2, "Cheesers", "Cheese and Crackers", "Cheddar Cheese, Water Crackers", 3.99);
            KomodoCafeContent itemThree = new KomodoCafeContent(3, "BeastSam", "Roast Beef and Sourdough Bread", "Roast Beef, Sourdough Bread", 4.99);

            _contentRepo.AddMenuItems(itemOne);
            _contentRepo.AddMenuItems(itemTwo);
            _contentRepo.AddMenuItems(itemThree);

        }
    }

}
