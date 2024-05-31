namespace lab2
{
    public class Yacht
    {
        public string Name { get; set; }

        public double Speed { get; set; }

        public int Crew { get; set; }

        public double Draft { get; set; }

        public Yacht(string name, double speed, int crew, double draft)
        {
            Name = name;
            Speed = speed;
            Crew = crew;
            Draft = draft;
        }
    }
}
