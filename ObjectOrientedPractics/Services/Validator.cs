namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс, описывающий методы для проверки входящих значений.
    /// </summary>
    internal static class Validator
    {
        /// <summary>
        /// Метод, который проверяет число на положительность.
        /// </summary>
        /// <returns>Возвращает true or false.</returns>
        public static void AssertOnPositiveValue(int number, string propertyName)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{propertyName} не является положительным.");
            }
        }

        /// <summary>
        /// Метод, который проверяет число на положительность.
        /// </summary>
        /// <returns>Возвращает true or false.</returns>
        public static void AssertOnPositiveValue(double number, int propertyName)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{propertyName} не является положительным.");
            }
        }

        /// <summary>
        /// Метод, который проверяет число на вхождение в заданный диапазон.
        /// </summary>
        /// <param name="value">Число, которое нужно проверить.</param>
        /// <param name="min">Минимальная граница диапазона (не включительно).</param>
        /// <param name="max">Максимальная граница диапазона (не включительно).</param>
        /// <returns>Возвращает true or false.</returns>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException(
                    $"{propertyName} должен находиться в диапазоне от {min} до {max}.");
            }
        }

        /// <summary>
        /// Метод, который проверяет число на вхождение в заданный диапазон.
        /// </summary>
        /// <param name="value">Число, которое нужно проверить.</param>
        /// <param name="min">Минимальная граница диапазона (не включительно).</param>
        /// <param name="max">Максимальная граница диапазона (не включительно).</param>
        /// <returns>Возвращает true or false.</returns>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException(
                    $"{propertyName} должен находиться в диапазоне от {min} до {max}.");
            }
        }

        /// <summary>
        /// Метод, который проверяет входящую строку на наличие латиницы.
        /// </summary>
        /// <param name="name">Строка.</param>
        /// <returns>True or false.</returns>
        public static bool CheckStringContainsOnlyEnglishLetters(string? value)
        {
            bool flag = true;
            foreach (char c in value)
            {
                if (!(((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')) || (c == ' ')))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        /// <summary>
        /// Метод, который проверяет входяшую строку на наличие адреса на латинице.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <returns>True or false.</returns>
        public static bool CheckStringContainsAddress(string? value)
        {
            bool flag = true;
            if (!string.IsNullOrWhiteSpace(value))
            {
                foreach (char c in value)
                {
                    if (!(((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')) || (c == ' ') || (c == ',') ||
                        ((c >= '0') && (c <= '9'))))
                    {
                        flag = false;
                        break;
                    }
                }
            }

            return flag;
        }

        /// <summary>
        /// Метод, который сравнивает длину входящей строки и максимально возможную ее длину.
        /// </summary>
        /// <param name="value">Входящая строка.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Имя свойства, в котором вызвали этот метод.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.ToString().Length > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} должен быть меньше {maxLength+1} символов.");
            }
        }
    }
}