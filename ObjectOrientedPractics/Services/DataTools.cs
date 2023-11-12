using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class DataTools
    {
        public static string FilterTextCriterion { get; set; }

        public static bool ItemsFilterText(Item item)
        {
            return item.Name.ToLower() == FilterTextCriterion.ToLower();
        }

        public static List<Item> ItemsFilter(List<Item> items, Func<Item, bool> filter)
        {
            List<Item> result = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                if (filter(items[i]))
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        public static bool SortByName(Item item1, Item item2)
        {
            for (int i = 0; i < (item1.Name.Length > item2.Name.Length ? item2.Name.Length : item1.Name.Length); i++)
            {
                if (item1.Name.ToCharArray()[i] > item2.Name.ToCharArray()[i]) return false;
                if (item1.Name.ToCharArray()[i] < item2.Name.ToCharArray()[i]) return true;
            }
            return false;
        }

        public static bool SortByCostAscending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        public static bool SortByCostDescending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        public static List<Item> ItemsSort(List<Item> items, Func<Item, Item, bool> sort)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count; j++)
                {
                    if (sort(items[i], items[j]))
                    {
                        Item temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }
            return items;
        }
    }
}