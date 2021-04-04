using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Repository
{
    public class MenuContentRepository
    {
        public List<KomodoCafeContent> _listOfKomodoCafeContent = new List<KomodoCafeContent>();

        public void AddMenuItems(KomodoCafeContent item)
        {
            _listOfKomodoCafeContent.Add(item);
        }

        public List<KomodoCafeContent> GetMenuItems()
        {
            return _listOfKomodoCafeContent;
        }

        public bool DeleteMenuItems(string meal)
        {
            KomodoCafeContent item = GetMenuItemsToDelete(meal);

            if (item == null)
            {
                return false;
            }
            int contentCount = _listOfKomodoCafeContent.Count;
            _listOfKomodoCafeContent.Remove(item);

            if (contentCount > _listOfKomodoCafeContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public KomodoCafeContent GetMenuItemsToDelete(string meal)
        {
            foreach (KomodoCafeContent item in _listOfKomodoCafeContent)
            {
                if (item.MealName == meal)
                {
                    return item;
                }

            }
            return null;
        }
    }
}
