namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var regatta = new Regatta
            {
                new Yacht("Яхта 1", 20, 5, 1.5),
                new Yacht("Яхта 2", 25, 6, 1.6),
                new Yacht("Яхта 3", 18, 4, 1.4),
                new Yacht("Яхта 4", 30, 7, 1.7),
                new Yacht("Яхта 5", 22, 5, 1.5)
            };

            Console.WriteLine("Призеры регаты:");

            foreach (var yacht in regatta.Winners())
            {
                Console.WriteLine(yacht.Name);
            }

            Console.WriteLine($"Отношение скорости к осадке для самого медленного корабля: {regatta.SlowestYachtSpeedToDraftRatio():F2}");
        }
    }
}

