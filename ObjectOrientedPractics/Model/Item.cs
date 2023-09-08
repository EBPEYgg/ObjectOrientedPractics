using Newtonsoft.Json;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий товар в магазине.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Уникальный номер товара.
        /// </summary>
        private int _id;

        /// <summary>
        /// Счетчик товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private int _cost;

        /// <summary>
        /// Возвращает и задает название товара. Должно иметь длину до 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set 
            {
                Validator.AssertStringOnLength(value, 200, Name);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара. Должно иметь длину до 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                Validator.AssertStringOnLength(value, 1000, Info);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. 
        /// Значение должно находиться в диапазоне от 0 до 100000.
        /// </summary>
        public int Cost
        {
            get => _cost;
            set
            {
                Validator.AssertValueInRange(value, 0, 100000, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает счетчик товаров.
        /// </summary>
        [JsonProperty]
        public int AllItemsCount
        {
            get => _allItemsCount;
            private set => _allItemsCount = value;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        [JsonProperty]
        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="id">Уникальный номер товара.</param>
        /// <param name="name">Название товара. Должно иметь длину до 200 символов.</param>
        /// <param name="info">Описание товара. Должно иметь длину до 1000 символов.</param>
        /// <param name="cost">Стоимость товара. 
        /// Значение должно находиться в диапазоне от 0 до 100000 (не включительно).</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, int cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            AllItemsCount++;
            Id = _allItemsCount;
            Category = category;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Строка: "Уникальный идентификатор / Стоимость / Название товара ".</returns>
        public override string ToString()
        {
            return $"{Id} / " +
                $"{Cost} / " +
                $"{Name}";
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