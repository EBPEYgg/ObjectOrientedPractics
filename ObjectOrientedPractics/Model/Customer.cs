using ObjectOrientedPractics.Services;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий покупателя.
    /// </summary>
    internal class Customer
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
        /// Адрес доставки покупателя.
        /// </summary>
        private string _address;

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
        /// Возвращает и задает адрес доставки покупателя. Должно иметь длину до 500 символов.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                Validator.AssertStringOnLength(value, 200, Address);
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает счетчик покупателей.
        /// </summary>
        public static int AllItemsCount
        {
            get => _allCustomersCount;
            private set
            {
                _allCustomersCount = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get => _id;
            private set
            {
                _id = value;
            }
        }

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
        /// <param name="address">Адрес доставки покупателя. Должно иметь длину до 500 символов.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _allCustomersCount++;
            Id = _allCustomersCount;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Строка: "Уникальный идентификатор / Полное имя / Адрес ".</returns>
        public override string ToString()
        {
            return $"{_id} / " +
            $"{Fullname} / " +
                $"{Address}";
        }

        /// <summary>
        /// Клонирование объекта класса для редактирования его через TextBox.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}