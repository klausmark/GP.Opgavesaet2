using System;
using GP.Opgavesaet2.Opgave2_1;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave21ViewModel : NotifyBase
    {
        private readonly Opgave21 _opgave21;

        public Opgave21ViewModel()
        {
            _opgave21 = new Opgave21();

            TilfældigeTal = _opgave21.Numbers.ToPrettyString();
            TilfældigeTalIOmvendtRækkefølge = _opgave21.NumbersReversed.ToPrettyString();

            OpdaterVærdierMedOpgave21();

            _opgave21.SomethingChanged += _opgave21_SomethingChanged;
        }

        private void _opgave21_SomethingChanged(object sender, EventArgs e)
        {
            OpdaterVærdierMedOpgave21();
        }

        private void OpdaterVærdierMedOpgave21()
        {
            UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdier =
                _opgave21.NumbersAboveOrBelowMinAndMax.ToPrettyString();
            UdsnitAfDeTilfældigeTalUdFraPlaceringIArray = 
                _opgave21.NumbersWithinStartAndEndPosition.ToPrettyString();
        }

        public string TilfældigeTal
        {
            get { return GetFieldWhereDefaultValueIs(""); }
            set { SetField(value); }
        }

        public string TilfældigeTalIOmvendtRækkefølge { get; set; }
        public string UdsnitAfDeTilfældigeTalUdFraPlaceringIArray
        {
            get { return GetFieldWhereDefaultValueIs(""); }
            set { SetField(value); }
        }

        public int UdsnitAfDeTilfældigeTalUdFraPlaceringIArrayFra
        {
            get { return _opgave21.StartPosition; }
            set { _opgave21.StartPosition = value; }
        }

        public int UdsnitAfDeTilfældigeTalUdFraPlaceringIArrayTil
        {
            get { return _opgave21.EndPosition; }
            set { _opgave21.EndPosition = value; }
        }

        public string UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdier
        {
            get { return GetFieldWhereDefaultValueIs(""); }
            set { SetField(value); }
        }

        public int UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdierMindsteVærdi
        {
            get { return _opgave21.Min; }
            set { _opgave21.Min = value; }
        }

        public int UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdierHøjesteVærdi
        {
            get { return _opgave21.Max; }
            set { _opgave21.Max = value; }
        }

        public int Antal { get; set; }
        public int Føerste { get; set; }
    }
}