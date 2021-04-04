using _04_Komodo_Outings_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04_Komodo_Outings_Console
{
    class ProgramUI
    {
        private KomodoOutingsRepository _contentRepo = new KomodoOutingsRepository();
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
                Console.WriteLine("Welcome to...\n" +
                    "Komodo Outings ----- K-o-m-o-d-o- O-u-t-i-n-g-s- ----- Komodo Outings");
                Console.WriteLine("\n" +
                    "Please select an option number (1, 2, 3, or 4):\n" +
                    "1. Display a list of all outings\n" +
                    "2. Add individual outings to a list\n" +
                    "3. Display combined cost for all outings\n" +
                    "4. Display outing costs by type of outing");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayAllOutings();
                        break;

                    case "2":
                        AddOutings();
                        break;

                    case "3":
                        DisplayAllOutingsCosts();
                        break;
                    case "4":
                        DisplayOutingCostsByType();
                        break;
                    default:
                        Console.WriteLine("Please enter 1, 2, or 3:");
                        break;
                }

            }
        }
        private void DisplayAllOutings()
        {
            Console.Clear();
            List<KomodoOutings> listOfOutings = _contentRepo.DisplayAllOutings();
            
            
            foreach(KomodoOutings item in listOfOutings)
            {
                Console.WriteLine($"Event Type:{item.EventType}\n"+$"Number of People:{item.NumberOfPeople}\n"+$"Date of Event:{item.DateOfEvent}\n"+$"Cost per Person:${item.CostPerPerson}\n"+$"Event Total Cost: ${item.EventTotalCost}\n");

            }
        }
         private void AddOutings()
        {
            KomodoOutings newoutings = new KomodoOutings();
            Console.WriteLine("Please enter the Event Type:");
                newoutings.EventType = Console.ReadLine();

            Console.WriteLine("Please enter the number of people attending:");
            string numberOfPeopleString = Console.ReadLine();
            newoutings.NumberOfPeople = int.Parse(numberOfPeopleString);

            Console.WriteLine("Please enter the Date of the outing (EXAMPLE: April, 3 2021):");
            newoutings.DateOfEvent = Console.ReadLine();

            Console.WriteLine("Please enter the cost per person for this event:");
            string costPerPersonString = Console.ReadLine();
            newoutings.CostPerPerson = int.Parse(costPerPersonString);

            Console.WriteLine("Please enter the total cost for this event:");
            string eventTotalCost = Console.ReadLine();
            newoutings.EventTotalCost = int.Parse(eventTotalCost);

            _contentRepo.AddOutingsToList(newoutings);
      
        }

        private void DisplayAllOutingsCosts()
        {
            Console.Clear();
            List<KomodoOutings> listOfOutings = _contentRepo.DisplayAllOutings();


            foreach (KomodoOutings item in listOfOutings)
            {
                Console.WriteLine($"Event Name:{item.EventType}\n"+ $"Cost: ${item.EventTotalCost}\n");

            }
            Console.WriteLine("Total Event Cost is $25,000");
            var numbers = new List<double>();
            double sum = numbers.Sum();
            Console.WriteLine(sum);

        }

        private void DisplayOutingCostsByType()
        {

            
            Console.Clear();
            List<KomodoOutings> listOfOutings = _contentRepo.DisplayAllOutings();


            foreach (KomodoOutings item in listOfOutings)
            {
                Console.WriteLine($"Event Type:{item.EventType}\n" + $"Event Total Cost: ${item.EventTotalCost}\n");

            }

        }

        private void SeedMenu()
        {
            double golfcost = 6000;
            String.Format("{0:#,##0.##}", 6000);
            

            KomodoOutings golf = new KomodoOutings("Golf", 300, "April 1st 2021", 20, golfcost);
            KomodoOutings bowling = new KomodoOutings("Bowling", 200, "April 2nd, 2021", 10, 2000);
            KomodoOutings amusementPark = new KomodoOutings("Amusement Park", 400, "April 4th, 2021", 30, 12000);
            KomodoOutings concert = new KomodoOutings("Concert", 100, "April 3rd, 2021", 50, 5000);

            _contentRepo.AddOutingsToList(golf);
            _contentRepo.AddOutingsToList(bowling);
            _contentRepo.AddOutingsToList(amusementPark);
            _contentRepo.AddOutingsToList(concert);

            

        }
    }
}


