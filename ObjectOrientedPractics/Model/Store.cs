namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, который хранит данные всех товаров и покупателей, 
    /// предоставляя их для вкладок ItemsTab и CustomersTab
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
        }
    }
}