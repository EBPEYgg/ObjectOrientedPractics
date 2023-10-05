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
        private DateTime _creationDate;

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
            private set => _allOrdersCount = value;
        }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор.
        /// </summary>
        [JsonProperty]
        public int Id
        {
            get => _id;
            private set => _id = value;
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
        /// Возвращает и задает дату создания заказа.
        /// </summary>
        public DateTime CreationDate
        {
            get => _creationDate;
            private set => _creationDate = value;
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
            get
            {
                if (_items == null || _items.Count == 0)
                {
                    _amount = 0;
                    return 0;
                }
                for (int i = 0; i < _items.Count; i++)
                {
                    _amount = _amount + _items[i].Cost;
                }
                return _amount;
            }
        }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

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
        public Order(Address address, Cart Cart, OrderStatus orderStatus)
        {
            _creationDate = DateTime.Now;
            Address = address;
            _items = Cart.Items;
            _amount = Amount;
            OrderStatus = orderStatus;
            AllOrdersCount++;
            Id = _allOrdersCount;
        }
    }
}