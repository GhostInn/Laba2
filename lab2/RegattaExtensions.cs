namespace lab2
{
    // Определяем статический класс RegattaExtensions, который содержит методы расширения для класса Regatta
    public static class RegattaExtensions
    {
        // Метод расширения Winners для класса Regatta, который возвращает новый экземпляр класса Regatta,
        // содержащий первые три яхты из экземпляра regatta, отсортированные по убыванию их скорости
        public static Regatta Winners(this Regatta regatta)
        {
            // Создаем переменную sortedYachts, которая содержит отсортированный список яхт из экземпляра regatta
            // в порядке убывания их скорости. Используем метод расширения OrderByDescending для класса IEnumerable<T>
            var sortedYachts = regatta.OrderByDescending(yacht => yacht.Speed);

            // Возвращаем новый экземпляр класса Regatta, который содержит первые три яхты из отсортированного списка
            // sortedYachts. Используем метод расширения Take для класса IEnumerable<T>
            return new Regatta(sortedYachts.Take(3));
        }

        // Метод расширения SlowestYachtSpeedToDraftRatio для класса Regatta, который вычисляет отношение скорости
        // к осадке для самого медленного корабля в экземпляре regatta
        public static double SlowestYachtSpeedToDraftRatio(this Regatta regatta)
        {
            // Если переменная reggata равна null, то выводим сообщение об ошибке и выбрасываем исключение
            
            if (regatta == null)
            {
                throw new ArgumentNullException("null");
            }
            
            // Создаем переменную slowestYacht, которая содержит самый медленный корабль из экземпляра regatta.
            // Используем метод расширения MinBy для класса IEnumerable<T>
            var slowestYacht = regatta.MinBy(yacht => yacht.Speed);

            // Если переменная slowestYacht равна null, то выводим сообщение об ошибке и выбрасываем исключение
            if (slowestYacht == null)
            {
                throw new ArgumentNullException("null");
            }
            
            // Вычисляем отношение скорости к осадке для самого медленного корабля и возвращаем его из метода
            return slowestYacht.Speed / slowestYacht.Draft;
        }
    }
}