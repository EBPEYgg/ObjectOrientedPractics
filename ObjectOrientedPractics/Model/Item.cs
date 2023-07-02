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
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string? _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string? _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private int _cost;

        /// <summary>
        /// Возвращает и задает название товара. Должно иметь длину до 200 символов.
        /// </summary>
        public string? Name
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
        public string? Info
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
        public Item(string name, string info, int cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}