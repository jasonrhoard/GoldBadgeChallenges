using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _02_Komodo_Claims_Repository;


namespace _02_Komodo_Claims_Console
{
    class ProgramUI
    {
        private KomodoClaimsRepository _contentRepo = new KomodoClaimsRepository();
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
                    "Komodo Claims ----- K-o-m-o-d-o- C-l-a-i-m-s- ----- Komodo Claim");
                Console.WriteLine("\n" +
                    "Please select an option number (1, 2 or 3):\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;

                    case "2":
                        TakeCareOfNextClaim();
                        break;

                    case "3":
                        EnterNewClaim();
                        break;
                    default:
                        Console.WriteLine("Please enter 1, 2, or 3:");
                        break;
                }

            }

        }
        public void SeeAllClaims()
        {

            List<KomodoClaims> listOfKomodoClaims = _contentRepo.SeeAllKomodoClaims();

            foreach (KomodoClaims item in listOfKomodoClaims)
            {
                Console.WriteLine($"Claim ID:\n{item.ClaimId}" + $"Type:\n{item.ClaimType}" + $"Description{item.ClaimDescription}\n" + $"Amount{item.ClaimAmount}\n" + $"Date of Accident{item.DateOfAccident}\n" + $"Date of Claim{item.DateOfClaim}\n" + $"Is Valid?\n{item.IsValid}");

            }

        }

        private void TakeCareOfNextClaim()
        {
            string dateOneFirst = "4/25/18";
            DateTime date1 = DateTime.Parse(dateOneFirst);
            string dateOneSecond = "4/27/18";
            DateTime date2 = DateTime.Parse(dateOneSecond);
            KomodoClaims one = new KomodoClaims(1, "Car", "Car accident on 465.", 400.00, date1, date2, true);
            _contentRepo.EnterNewClaimInfo(one);

            List<KomodoClaims> listOfKomodoClaims = _contentRepo.SeeAllKomodoClaims();

            foreach (KomodoClaims item in listOfKomodoClaims)
            {
                Console.WriteLine($"Claim ID:\n{item.ClaimId}" + $"Type:\n{item.ClaimType}" + $"Description{item.ClaimDescription}\n" + $"Amount{item.ClaimAmount}\n" + $"Date of Accident{item.DateOfAccident}\n" + $"Date of Claim{item.DateOfClaim}\n" + $"Is Valid?\n{item.IsValid}");
                Console.WriteLine("Take care of this Claim (y/n)");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "y":
                        Console.WriteLine("Claim taken care of!");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "n":
                        //SeeClaimTwo();
                        break;

                    default:
                        Console.WriteLine("Please enter y or n");
                        break;
                }

            }
        }


        public void EnterNewClaim()
        {
            KomodoClaims newClaim = new KomodoClaims();

            Console.WriteLine("Please enter the Claim ID:");
            string claimAsString = Console.ReadLine();
            newClaim.ClaimId = int.Parse(claimAsString);

            Console.WriteLine("Please enter the number of the claim Type (Car, Home, or Theft):");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Please enter a short Description:");
            newClaim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Please enter the claim Amount(EXAMPLE 5000):");
            string amountAsString = Console.ReadLine();
            newClaim.ClaimAmount = int.Parse(amountAsString);

            Console.WriteLine("Please enter the Date of Accident (EXAMPLE 4/31/2021):");
            DateTime accidentDate = DateTime.Parse(Console.ReadLine());
            newClaim.DateOfAccident = accidentDate;

            Console.WriteLine("Please enter the Date of Claim (EXAMPLE 6/23/2021):");
            DateTime claimDate = DateTime.Parse(Console.ReadLine());
            newClaim.DateOfClaim = claimDate;

            Console.WriteLine("Is the claim valid (Claim date 30 days or less from Accident Date) y/n?");
            string isValid = Console.ReadLine();

            switch (isValid)
            {
                case "y":
                    newClaim.IsValid = true;
                    break;

                case "n":
                    newClaim.IsValid = false;
                    break;

                default:
                    Console.WriteLine("Please y or n");
                    break;
            }

            _contentRepo.EnterNewClaimInfo(newClaim);


        }


        public void SeedMenu()
        {
            string dateOneFirst = "4/25/18";
            DateTime date1 = DateTime.Parse(dateOneFirst);
            string dateOneSecond = "4/27/18";
            DateTime date2 = DateTime.Parse(dateOneSecond);
            KomodoClaims one = new KomodoClaims(1, "Car", "Car accident on 465.", 400.00, date1, date2, true);


            string dateTwoFirst = "4/11/18";
            DateTime date1Claim2 = DateTime.Parse(dateTwoFirst);
            string dateTwoSecond = "4/12/18";
            DateTime date2Claim2 = DateTime.Parse(dateTwoSecond);
            KomodoClaims two = new KomodoClaims(2, "Home", "House fire in kitchen.", 4000.00, date1Claim2, date2Claim2, true);


            string dateThreeFirst = "4/27/18";
            DateTime date1Claim3 = DateTime.Parse(dateThreeFirst);
            string dateThreeSecond = "6/01/18";
            DateTime date2Claim3 = DateTime.Parse(dateThreeSecond);
            KomodoClaims three = new KomodoClaims(3, "Theft", "Stolen Pancakes.", 4.00, date1Claim3, date2Claim3, false);

            _contentRepo.EnterNewClaimInfo(one);
            _contentRepo.EnterNewClaimInfo(two);
            _contentRepo.EnterNewClaimInfo(three);

            DataTable dt = new DataTable();
            dt.Columns.Add("ClaimID", Type.GetType("System.Int32"));
            dt.Columns.Add("Type", Type.GetType("System.String"));
            dt.Columns.Add("Description", Type.GetType("System.String"));
            dt.Columns.Add("Amount", Type.GetType("System.Decimal"));
            dt.Columns.Add("DateOfAccident", Type.GetType("System.String"));
            dt.Columns.Add("DateOfClaim", Type.GetType("System.String"));
            dt.Rows.Add(new object[] { 1, "Car", "Car accident on 465.", 400.00, "4/25/18", "4/27/18" });
            dt.Rows.Add(new object[] { 2, "Home", "House fire in kitchen.", 4000.00, "4/11/18", "4/12/18" });
            dt.Rows.Add(new object[] { 3, "Theft", "Stolen panckes", 4.00, "04/27/18", "6/1/18" });
            Console.WriteLine(dt);
        }
    }
}

