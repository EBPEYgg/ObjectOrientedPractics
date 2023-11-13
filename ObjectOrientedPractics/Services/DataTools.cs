using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс, описывающий различные методы по обработке данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Критерий для фильтра по тексту.
        /// </summary>
        public static string FilterTextCriterion { get; set; }

        /// <summary>
        /// Метод, который ищет совпадения между критерием для фильтра и названием товара.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>True if item.Name == FilterTextCriterion; <br/>False otherwise.</returns>
        public static bool ItemsFilterText(Item item)
        {
            return item.Name.ToLower() == FilterTextCriterion.ToLower();
        }

        /// <summary>
        /// Метод, который фильтрует список товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="filter">Заданный фильтр.</param>
        /// <returns>Список с подходящими под заданный фильтр товарами.</returns>
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

        /// <summary>
        /// Метод, который сортирует товары по названию в алфавитном порядке.
        /// </summary>
        /// <param name="item1">Товар 1.</param>
        /// <param name="item2">Товар 2.</param>
        /// <returns>True or false.</returns>
        public static bool SortByName(Item item1, Item item2)
        {
            for (int i = 0; i < (item1.Name.Length > item2.Name.Length ? item2.Name.Length : item1.Name.Length); i++)
            {
                if (item1.Name.ToCharArray()[i] > item2.Name.ToCharArray()[i])
                {
                    return false;
                }
                if (item1.Name.ToCharArray()[i] < item2.Name.ToCharArray()[i])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод, который сортирует товары по возрастанию цены.
        /// </summary>
        /// <param name="item1">Товар 1.</param>
        /// <param name="item2">Товар 2.</param>
        /// <returns>True or false.</returns>
        public static bool SortByCostAscending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        /// <summary>
        /// Метод, который сортирует товары по убыванию цены.
        /// </summary>
        /// <param name="item1">Товар 1.</param>
        /// <param name="item2">Товар 2.</param>
        /// <returns>True or false.</returns>
        public static bool SortByCostDescending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        /// <summary>
        /// Метод, который сортирует товары.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="sort">Заданная сортировка.</param>
        /// <returns>Список товаров.</returns>
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