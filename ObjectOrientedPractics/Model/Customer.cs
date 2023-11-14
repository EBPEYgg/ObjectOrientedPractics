using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий покупателя.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный номер покупателя.
        /// </summary>
        private int _id;

        /// <summary>
        /// Счетчик покупателей.
        /// </summary>
        private static int _allCustomersCount = 0;

        /// <summary>
        /// Полное ФИО покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Корзина товаров покупателя.
        /// </summary>
        private Cart _cart = new();

        /// <summary>
        /// Заказ покупателя.
        /// </summary>
        private Order _order = new();

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Возвращает и задает ФИО покупателя. Должно иметь длину до 200 символов.
        /// </summary>
        public string Fullname
        {
            get => _fullname;
            set
            {
                Validator.AssertStringOnLength(value, 200, Fullname);
                _fullname = value;
            }
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
        /// Возвращает и задает корзину товаров покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value;
        }

        /// <summary>
        /// Возврашает и задает заказ покупателя.
        /// </summary>
        public Order Order
        {
            get => _order;
            set => _order = value;
        }

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public BindingList<Order> OrderList
        {
            get => _orders;
            set => _orders = value;
        }

        /// <summary>
        /// Возвращает счетчик покупателей.
        /// </summary>
        [JsonProperty]
        public int AllCustomersCount
        {
            get => _allCustomersCount;
            private set => _allCustomersCount = value;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        [JsonProperty]
        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        /// <summary>
        /// Возвращает и задает приоритет покупателя.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Возвращает и задает список скидок покупателя.
        /// </summary>
        public BindingList<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">ФИО покупателя. Должно иметь длину до 200 символов.</param>
        /// <param name="index">Почтовый индекс покупателя. Должно быть целым шестизначным числом.</param>
        /// <param name="country">Страна покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="city">Город покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="street">Улица покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="building">Номер дома покупателя. Должно иметь длину до 5 символов.</param>
        /// <param name="apartment">Номер квартиры покупателя. Должно иметь длину до 5 символов.</param>
        public Customer(string fullname, Address address, bool isPriority)
        {
            Fullname = fullname;
            IsPriority = isPriority;
            Address = address;
            OrderList = new BindingList<Order>();
            Discounts = new BindingList<IDiscount>();
            PointsDiscount pointsDiscount = new PointsDiscount();
            Discounts.Add(pointsDiscount);
            AllCustomersCount++;
            Id = _allCustomersCount;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Строка: "Уникальный идентификатор / Полное имя / Адрес".</returns>
        public override string ToString()
        {
            return $"{_id} / {Fullname} / {Address}";
        }

        /// <summary>
        /// Глубокое копирование объекта класса 
        /// для редактирования его через TextBox на CustomerTabs.
        /// </summary>
        /// <returns>Копия объекта класса.</returns>
        public object Clone()
        {
            Customer clone = (Customer)this.MemberwiseClone();
            clone.Address = (Address)this.Address.Clone();
            return clone;
        }
    }
}