using _01_KomodoCafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_KomodoCafe_Tests
{
    [TestClass]
    public class KomodoCafeTests
    {
        private KomodoCafeContent _content;
        private MenuContentRepository _repo;


        [TestInitialize]
        public void Arrange()
        {
            _content = new KomodoCafeContent(1, "HumCar", "Hummus and Baby Carrots", "Hummus, Baby Carrots", 2.99);
            _repo = new MenuContentRepository();

            _repo.AddMenuItems(_content);
        }
        [TestMethod]
        public void AddToList_ReturnNotNull()
        {
            KomodoCafeContent content = new KomodoCafeContent();
            content.MealName = "HumCar";
            MenuContentRepository repository = new MenuContentRepository();

            repository.AddMenuItems(content);
            KomodoCafeContent contentfromMenu = repository.GetMenuItemsToDelete("HumCar");

            Assert.IsNotNull(contentfromMenu);

            //Get
            //Delete
        }

        [TestMethod]
        public void ViewMenuItems_ReturnMenu()


        {

        }
    }
}
