using ObjectOrientedPractics.Services;

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
        private readonly string _id;

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
        }
    }
}
