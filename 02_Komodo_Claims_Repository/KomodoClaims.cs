using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Komodo_Claims_Repository
{
    public enum TypeOfClaim 
    {
        Car =1,
        Home,
        Theft
    }
    public class KomodoClaims
    {
        public int ClaimId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimDescription { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime DateOfClaim { get; set; }

        public bool IsValid { get; set; }

        public KomodoClaims() { }
        public KomodoClaims(int claimID, string claimType, string claimDescription, double claimAmount, DateTime dateOfAccident, DateTime dateOfClaim, bool isValid)
        {
            ClaimId = claimID;
            ClaimType = claimType;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
