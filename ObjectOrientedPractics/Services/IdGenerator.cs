namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс, описывающий метод для генерации ID (уникального идентификатора).
    /// </summary>
    internal static class IdGenerator
    {
        /// <summary>
        /// Метод, который генерирует следующий ID (уникальный идентификатор) от заданного.
        /// </summary>
        /// <param name="id">Уникальный идентификатор.</param>
        /// <returns>Следующий ID (id + 1).</returns>
        public static int GetNextId(int id)
        {
            return id++;
        }
    }
}
