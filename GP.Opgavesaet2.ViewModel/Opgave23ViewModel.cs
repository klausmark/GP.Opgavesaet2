using System;
using GP.Opgavesaet2.Opgave23;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave23ViewModel : NotifyBase
    {
        public Opgave23ViewModel()
        {
            Year = DateTime.Now.Year;
        }
        public int Year
        {
            get { return GetField<int>(); }
            set
            {
                SetField(value);
                UpdateLeapDescription();
            }
        }

        private void UpdateLeapDescription()
        {
            LeapDescription = new LeapCalculator(Year).IsLeap() ? $"{Year} er et skudår" : $"{Year} er ikke et skudår";
        }

        public string LeapDescription
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }


    }
}