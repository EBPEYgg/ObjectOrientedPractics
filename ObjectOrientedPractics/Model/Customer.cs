﻿using ObjectOrientedPractics.Services;

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
        private string? _fullname;

        /// <summary>
        /// Возвращает и задает ФИО покупателя. Должно иметь длину до 200 символов.
        /// </summary>
        public string? Fullname
        {
            get => _fullname;
            set
            {
                if (Fullname != null)
                {
                    Validator.AssertStringOnLength(value, 200, Fullname);
                    _fullname = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки покупателя.
        /// </summary>
        public Address Address { get; set; }

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
        /// <param name="index">Почтовый индекс покупателя. Должно быть целым шестизначным числом.</param>
        /// <param name="country">Страна покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="city">Город покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="street">Улица покупателя. Должно иметь длину до 50 символов.</param>
        /// <param name="building">Номер дома покупателя. Должно иметь длину до 5 символов.</param>
        /// <param name="apartment">Номер квартиры покупателя. Должно иметь длину до 5 символов.</param>
        public Customer(string fullname, int index, string country, 
            string city, string street, string building, string apartment)
        {
            Fullname = fullname;
            Address = new Address(index, country, city, street, building, apartment);
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