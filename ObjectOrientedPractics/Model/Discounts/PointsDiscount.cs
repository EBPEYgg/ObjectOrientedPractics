using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс, описывающий скидки накопительных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int _pointsCount;

        /// <summary>
        /// Возвращает и задает количество накопленных баллов.
        /// </summary>
        public int PointsCount
        {
            get => _pointsCount;
            private set
            {
                _pointsCount = value;
                Validator.AssertValueInRange(_pointsCount, 0, 999999, "PointsCount");
            }
        }

        /// <summary>
        /// Метод, который считает размер скидки, доступный для данного товара.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Округленный размер скидки.</returns>
        public int Calculate(List<Item> items)
        {
            double amount = 0;
            double amountWithDiscount;
            double discountSize = 0;

            for (int i = 0; i < items.Count; i++)
            {
                amount += items[i].Cost;
            }

            double maxDiscount = amount * 0.3;

            if (PointsCount < maxDiscount)
            {
                amountWithDiscount = amount - PointsCount;
                discountSize = amount - amountWithDiscount;
            }

            else if (PointsCount >= maxDiscount)
            {
                amountWithDiscount = amount - maxDiscount;
                discountSize = amount - amountWithDiscount;
            }

            return Convert.ToInt32(discountSize);
        }

        /// <summary>
        /// Метод, который применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки с вычетом накопленных баллов.</returns>
        public int Apply(List<Item> items)
        {
            double amount = 0;
            double amountWithDiscount;
            double discountSize = 0;

            for (int i = 0; i < items.Count; i++)
            {
                amount += items[i].Cost;
            }

            double maxDiscount = amount * 0.3;

            if (PointsCount < maxDiscount)
            {
                amountWithDiscount = amount - PointsCount;
                discountSize = amount - amountWithDiscount;
            }

            else if (PointsCount >= maxDiscount)
            {
                amountWithDiscount = amount - maxDiscount;
                discountSize = amount - amountWithDiscount;
            }

            PointsCount -= Convert.ToInt32(discountSize);
            return Convert.ToInt32(discountSize);
        }

        /// <summary>
        /// Метод, который добавляет баллы на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;

            for (int i = 0; i < items.Count; i++)
            {
                amount += items[i].Cost;
            }

            PointsCount += Convert.ToInt32(Math.Round(amount * 0.1));
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <returns>Строка: "Накопительная - количество баллов".</returns>
        public override string ToString()
        {
            return $"Накопительная - {PointsCount} баллов";
        }
    }
}