using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Komodo_Outings_Repository
{
    public class KomodoOutings
    {

        public string EventType { get; set; }
        public int NumberOfPeople { get; set; }
        public string DateOfEvent { get; set; }
        public double CostPerPerson { get; set; }
        public double EventTotalCost { get; set; }
        public KomodoOutings(){}
        public KomodoOutings(string eventType, int numberOfPeople, string dateOfEvent, double costPerPerson, double eventTotalCost)
        {
            EventType = eventType;
            NumberOfPeople = numberOfPeople;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            EventTotalCost = eventTotalCost;
        }
    }
}
