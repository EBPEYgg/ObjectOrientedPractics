namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс, описывающий скидки.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Метод, который считает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Метод, который применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки с вычетом накопленных баллов.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Метод, который накапливает скидку или списывает баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}