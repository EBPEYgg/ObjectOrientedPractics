using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий заказ покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private int _id;

        /// <summary>
        /// Счетчик заказов.
        /// </summary>
        private static int _allOrdersCount = 0;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private string _creationDate;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        private int _amount;

        /// <summary>
        /// Возвращает счетчик заказов покупателей.
        /// </summary>
        [JsonProperty]
        public int AllOrdersCount
        {
            get => _allOrdersCount;
            set => _allOrdersCount = value;
        }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор.
        /// </summary>
        [JsonProperty]
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string CreationDate
        {
            get => _creationDate;
            set => _creationDate = value;
        }

        /// <summary>
        /// Возвращает и задает адрес доставки покупателя.
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// Возвращает и задает общую стоимость товаров.
        /// </summary>
        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает приоритет покупателя.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Возвращает и задает размер примененной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возваращет конечную стоимость заказа с учетом скидки.
        /// </summary>
        public double Total
        {
            get => Amount - DiscountAmount;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="index"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="building"></param>
        /// <param name="apartment"></param>
        public Order(string creationDate, Address address, Cart cart, OrderStatus orderStatus)
        {
            CreationDate = creationDate;
            Address = address;
            Items = cart.Items;
            Amount = cart.Amount;
            OrderStatus = orderStatus;
            AllOrdersCount++;
            Id = _allOrdersCount;
        }
    }
}