namespace lab2
{
    // Определяем класс Regatta, который наследуется от класса List<Yacht>. Это означает, что класс Regatta
    // имеет все свойства и методы класса List<Yacht>, а также может добавлять свои собственные свойства и методы
    public class Regatta : List<Yacht>
    {
        // Определяем конструктор по умолчанию для класса Regatta, который вызывает конструктор по умолчанию
        // базового класса List<Yacht>
        public Regatta()
        {
        }

        // Определяем конструктор для класса Regatta, который принимает в качестве параметра перечисление
        // (IEnumerable<Yacht>) яхт и вызывает конструктор базового класса List<Yacht>, который принимает
        // в качестве параметра перечисление яхт
        public Regatta(IEnumerable<Yacht> yachts) : base(yachts)
        {
            if (yachts == null)
            {
                throw new ArgumentNullException(nameof(yachts));
            }
            
        }
    }
}