using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, который хранит данные всех товаров и покупателей, 
    /// предоставляя их для вкладок ItemsTab и CustomersTab
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// TODO: xml
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// TODO: xml
        /// </summary>
        private List <Customer> _customers;

        /// <summary>
        /// TODO: xml
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// TODO: xml
        /// </summary>
        public List <Customer> Customers { get; set; }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = _items;
            Customers = _customers;
        }


        /*
        поле _items тип List<Item>;
        поле _customers тип List<Customer>;
        свойства + конструктор без параметров (но не пустой)
        */
    }
}