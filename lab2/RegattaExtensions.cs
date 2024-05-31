namespace lab2
{
    public static class RegattaExtensions
    {
        public static Regatta Winners(this Regatta regatta)
        {
            var sortedYachts = regatta.OrderByDescending(yacht => yacht.Speed);

            return new Regatta(sortedYachts.Take(3));
        }

        public static double SlowestYachtSpeedToDraftRatio(this Regatta regatta)
        {
            if (regatta == null)
            {
                throw new ArgumentNullException("null");
            }
            
            var slowestYacht = regatta.MinBy(yacht => yacht.Speed);

            if (slowestYacht == null)
            {
                throw new ArgumentNullException("null");
            }

            return slowestYacht.Speed / slowestYacht.Draft;
        }
    }
}
