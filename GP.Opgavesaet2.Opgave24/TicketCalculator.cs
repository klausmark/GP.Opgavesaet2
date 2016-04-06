namespace GP.Opgavesaet2.Opgave24
{
    public class TicketCalculator
    {
        private readonly float _basePrice;
        private readonly int _age;
        private readonly bool _isStudent;

        public TicketCalculator(float basePrice, int age, bool isStudent)
        {
            _basePrice = basePrice;
            _age = age;
            _isStudent = isStudent;
        }

        private int GetDiscount()
        {
            if (_age < 5) return 100;
            if (_age < 16) return 50;
            if (_age < 60) return _isStudent ? 25 : 0;
            return 50;
        }

        public float CalculatePrice()
        {
            return (100-GetDiscount())/100f*_basePrice;
        }
    }
}
