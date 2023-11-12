namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий корзину товаров покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        private int _amount;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возвращает и задает общую стоимость товаров.
        /// </summary>
        public int Amount
        {
            get
            {
                _amount = 0;
                if (_items == null || _items.Count == 0)
                {
                    return 0;
                }
                for (int i = 0; i < _items.Count; i++)
                {
                    _amount += _items[i].Cost;
                }
                return _amount;
            }
        }

        /// <summary>
        /// Клонирование объекта класса.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return new Cart();
        }
    }
}