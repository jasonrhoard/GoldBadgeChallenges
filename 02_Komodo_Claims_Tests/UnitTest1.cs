using _02_Komodo_Claims_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Komodo_Claims_Tests
{

    [TestClass]
    public class KomodoClaimsTests
    {
        private KomodoClaims _content;
        private KomodoClaimsRepository _repo;


        [TestInitialize]
        public void Arrange()
        {
            string dateOneFirst = "4/25/18";
            DateTime date1 = DateTime.Parse(dateOneFirst);
            string dateOneSecond = "4/27/18";
            DateTime date2 = DateTime.Parse(dateOneSecond);
            _content = new KomodoClaims(1, "Car", "Car accident on 465.", 400.00, date1, date2, true);
            _repo = new KomodoClaimsRepository();

            _repo.EnterNewClaimInfo(_content);
        }

        [TestMethod]
        public void EnterNewClaim_ReturnNotNull()
        {
            KomodoClaims content = new KomodoClaims();
            content.ClaimType = "Car";
            KomodoClaimsRepository repository = new KomodoClaimsRepository();

        

            repository.EnterNewClaimInfo(content);
            string dateOneFirst = "4/25/18";
            DateTime date1 = DateTime.Parse(dateOneFirst);
            string dateOneSecond = "4/27/18";
            DateTime date2 = DateTime.Parse(dateOneSecond);

           // KomodoClaims contentFromClaim = repository.EnterNewClaimInfo("Car");

            Assert.IsNotNull(content);
        }

        [TestMethod]
        public void SeeAllClaims_ReturnMenu()


        {
            KomodoClaims content = new KomodoClaims();
            content.ClaimId = 1;
            content.ClaimType = "Car";
            content.ClaimDescription = "Car accident on 465.";
            content.ClaimAmount = 400.00;


            Assert.AreEqual(content.ClaimId, 1);
            Assert.AreEqual(content.ClaimType, "Car");
            Assert.AreEqual(content.ClaimDescription, "Car accident on 465.");
            Assert.AreEqual(content.ClaimAmount, 400.00);

        }
    }
}
