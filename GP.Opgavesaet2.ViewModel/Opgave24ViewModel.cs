using GP.Opgavesaet2.Opgave24;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave24ViewModel : NotifyBase
    {
        private int _age;
        private bool _isStudent;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                CalculatePrice();
            }
        }

        public bool IsStudent
        {
            get { return _isStudent; }
            set
            {
                _isStudent = value;
                CalculatePrice();
            }
        }

        private void CalculatePrice()
        {
            Price = new TicketCalculator(17, Age, IsStudent).CalculatePrice();
        }

        public float Price
        {
            get { return GetField<float>(); }
            set { SetField(value); }
        }
    }
}