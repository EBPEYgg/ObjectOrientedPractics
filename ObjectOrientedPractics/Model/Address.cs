using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий адрес покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс покупателя.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна покупателя.
        /// </summary>
        private string? _country;

        /// <summary>
        /// Город покупателя.
        /// </summary>
        private string? _city;

        /// <summary>
        /// Улица покупателя.
        /// </summary>
        private string? _street;

        /// <summary>
        /// Номер дома покупателя.
        /// </summary>
        private string? _building;

        /// <summary>
        /// Номер квартиры покупателя.
        /// </summary>
        private string? _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс покупателя. Должно быть целым шестизначным числом.
        /// </summary>
        public int Index 
        {
            get => _index;
            set
            {
                if (value.ToString().Length == 6)
                {
                    _index = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает страну покупателя. Должно иметь длину до 50 символов.
        /// </summary>
        public string? Country
        {
            get => _country;
            set
            {
                if (Country != null)
                {
                    Validator.AssertStringOnLength(value, 50, Country);
                    _country = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает город покупателя. Должно иметь длину до 50 символов.
        /// </summary>
        public string? City
        {
            get => _city;
            set
            {
                if (City != null)
                {
                    Validator.AssertStringOnLength(value, 50, City);
                    _city = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает улицу покупателя. Должно иметь длину до 50 символов.
        /// </summary>
        public string? Street
        {
            get => _street;
            set
            {
                if (Street != null)
                {
                    Validator.AssertStringOnLength(value, 50, Street);
                    _street = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома покупателя. Должно иметь длину до 5 символов.
        /// </summary>
        public string? Building
        {
            get => _building;
            set
            {
                if (Building != null)
                {
                    Validator.AssertStringOnLength(value, 5, Building);
                    _building = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры покупателя. Должно иметь длину до 5 символов.
        /// </summary>
        public string? Apartment
        {
            get => _apartment;
            set
            {
                if (Apartment != null)
                {
                    Validator.AssertStringOnLength(value, 5, Apartment);
                    _apartment = value;
                }
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс покупателя. Должно быть целым шестизначным числом.</param>
        /// <param name="country">Страна покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="city">Город покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="street">Улица покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="building">Номер дома покупателя. Должно иметь длину до 5 символов.</param>
        /// <param name="apartment">Номер квартиры покупателя. Должно иметь длину до 5 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}