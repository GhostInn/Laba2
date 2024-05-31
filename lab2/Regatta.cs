namespace lab2
{
    public class Regatta : List<Yacht>
    {
        public Regatta()
        {
        }

        public Regatta(IEnumerable<Yacht> yachts) : base(yachts)
        {
            if (yachts == null)
            {
                throw new ArgumentNullException(nameof(yachts));
            }
            
        }
    }
}
