using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Komodo_Outings_Repository
{
    public class KomodoOutingsRepository
    {
        private List<KomodoOutings> _listOfOutings = new List<KomodoOutings>();

        public void AddOutingsToList(KomodoOutings outing)
        {
            _listOfOutings.Add(outing);
        }

        public List<KomodoOutings> DisplayAllOutings()
        {
            return _listOfOutings;
        }

        public KomodoOutings DisplayAllOutingsCosts(string cost)
        {
            foreach(KomodoOutings outingCost in _listOfOutings)
            {
                return outingCost;   
            }

            return null;

        }

        private KomodoOutings DisplayOutingCostByType(string type)
        {
            foreach(KomodoOutings outing in _listOfOutings)
            {
                if (outing.EventType == type)
                {
                    return outing;
                }
            }
            return null;
        }
    }
}
