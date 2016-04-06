namespace GP.Opgavesaet2.Opgave23
{
    public class LeapCalculator
    {
        private readonly int _year;

        public LeapCalculator(int year)
        {
            _year = year;
        }

        public bool IsLeap()
        {
            if (YearIsNotDivisibleBy4()) return false;

            if (YearIsNotACentury()) return true;

            if (YearIsDivisibleBy400()) return true;

            return false;
        }

        private bool YearIsNotDivisibleBy4()
        {
            return _year % 4 != 0;
        }

        private bool YearIsNotACentury()
        {
            return _year % 100 != 0;
        }

        private bool YearIsDivisibleBy400()
        {
            return _year % 400 == 0;
        }
    }
}
