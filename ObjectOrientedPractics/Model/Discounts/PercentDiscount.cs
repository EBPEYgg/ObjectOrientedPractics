namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount
    {
        /// <summary>
        /// Класс, описывающий скидку на конкретную категорию товаров.
        /// </summary>
        public class PercentDiscounts : IDiscount
        {
            /// <summary>
            /// Категория товаров, на которую предоставляется скидка.
            /// </summary>
            private Category _category;

            /// <summary>
            /// Текущая скидка.
            /// </summary>
            private double _currentDiscount = 0.01;

            /// <summary>
            /// Сумма, на которую покупатель уже сделал покупки.
            /// </summary>
            private double _amount;

            /// <summary>
            /// Возвращает и задает сумму, на которую покупатель совершил покупки в подходящей категории.
            /// </summary>
            public double Amount
            {
                get => _amount;
                private set => _amount = value;
            }

            /// <summary>
            /// Возвращает и задает текущую скидку покупателя на данную категорию.
            /// </summary>
            public double CurrentDiscount
            {
                get => _currentDiscount;
                private set => _currentDiscount = value;
            }

            /// <summary>
            /// Возвращает и задает категорию.
            /// </summary>
            public Category Category
            {
                get => _category;
                set => _category = value;
            }

            /// <summary>
            /// Метод, который считает размер скидки, доступный для товаров подходящей категории.
            /// </summary>
            /// <param name="items">Список товаров.</param>
            /// <returns>Размер скидки.</returns>
            public int Calculate(List<Item> items)
            {
                double amount = 0;
                double discountSize;

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Category == _category)
                    {
                        amount += items[i].Cost;
                    }

                    else
                    {
                        amount += 0;
                    }
                }

                discountSize = amount * CurrentDiscount;
                return Convert.ToInt32(discountSize);
            }

            /// <summary>
            /// Метод, который применяет скидку к товарам подходящей категории.
            /// </summary>
            /// <param name="items">Список товаров.</param>
            /// <returns>Размер скидки.</returns>
            public int Apply(List<Item> items)
            {
                double amount = 0;
                double discountSize;

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Category == _category)
                    {
                        amount += items[i].Cost;
                    }
                    else
                    {
                        amount += 0;
                    }
                }

                discountSize = amount * CurrentDiscount;
                return Convert.ToInt32(discountSize);
            }

            /// <summary>
            /// Метод, который обновляет накопительную скидку 
            /// на основе суммы покупок покупателя в данной категории.
            /// </summary>
            /// <param name="items">Список товаров.</param>
            public void Update(List<Item> items)
            {
                int amountToIncreaseDiscount = 1000;
                double maxDiscount = 0.1;
                int counter = 0;

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Category == _category)
                    {
                        Amount += items[i].Cost;
                        if (Amount >= amountToIncreaseDiscount && 
                            CurrentDiscount < maxDiscount && 
                            counter == 0)
                        {
                            CurrentDiscount += 0.01;
                            counter++;
                        }
                    }
                    else
                    {
                        Amount += 0;
                    }
                }
            }

            /// <summary>
            /// Переопределение метода ToString() для класса <see cref="PercentDiscount"/>.
            /// </summary>
            /// <returns>Строка: "Процентная "{Категория}" - {количество}%".</returns>
            public override string ToString()
            {
                return $"Процентная \"{_category}\" - {Math.Round(_currentDiscount, 2) * 100}%";
            }
        }
    }
}