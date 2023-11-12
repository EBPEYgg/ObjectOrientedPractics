using ObjectOrientedPractics.Services;
using System.Security.Cryptography;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий адрес покупателя.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Почтовый индекс покупателя.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна покупателя.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город покупателя.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица покупателя.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома покупателя.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры покупателя.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс покупателя. Должно быть целым шестизначным числом.
        /// </summary>
        public int Index 
        {
            get => _index;
            set
            {
                if (value.ToString().Length != 6)
                {
                    throw new ArgumentException("Индекс должен состоять только из 6 цифр.");
                }
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает страну покупателя. Должно иметь длину до 50 символов.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                Validator.AssertStringOnLength(value, 50, Country);
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает город покупателя. Должно иметь длину до 50 символов.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                Validator.AssertStringOnLength(value, 50, City);
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает улицу покупателя. Должно иметь длину до 50 символов.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                Validator.AssertStringOnLength(value, 50, Street);
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома покупателя. Должно иметь длину до 5 символов.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                Validator.AssertStringOnLength(value, 5, Building);
                _building = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры покупателя. Должно иметь длину до 5 символов.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                Validator.AssertStringOnLength(value, 5, Apartment);
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
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

        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }

        /// <summary>
        /// <inheritdoc cref="ICloneable"/>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// <inheritdoc cref="IEquatable{T}"/>
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Address other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Перегрузка. <inheritdoc cref="IEquatable{T}"/>
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            if (other is not Address)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            var address = (Address)other;

            return Equals(address);
        }

        /// <summary>
        /// Событие на изменение какого-либо поля адреса.
        /// </summary>
        public event EventHandler AddressChanged;
    }
}