using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Komodo_Claims_Repository
{
    public class KomodoClaimsRepository
    {
        public List<KomodoClaims> _listOfKomodoClaims = new List<KomodoClaims>();

        public List<KomodoClaims> SeeAllKomodoClaims()
        {
            return _listOfKomodoClaims;

        }

        public void TakeCareOfNextClaim()
        {
            Console.Clear();
            SeeAllKomodoClaims();

        }

        public void EnterNewClaimInfo(KomodoClaims claim)
        {
            _listOfKomodoClaims.Add(claim);
        }
    }
}
