using System;
using GP.Opgavesaet2.Opgave21;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave21ViewModel : NotifyBase
    {
        private readonly Opgave21Solution _opgave21Solution;
        private int _nummer;

        public Opgave21ViewModel()
        {
            _opgave21Solution = new Opgave21Solution();

            TilfældigeTal = _opgave21Solution.Numbers.ToPrettyString();
            TilfældigeTalIOmvendtRækkefølge = _opgave21Solution.NumbersReversed.ToPrettyString();

            OpdaterVærdierMedOpgave21();

            _opgave21Solution.SomethingChanged += _opgave21_SomethingChanged;
        }

        private void _opgave21_SomethingChanged(object sender, EventArgs e)
        {
            OpdaterVærdierMedOpgave21();
        }

        private void OpdaterVærdierMedOpgave21()
        {
            UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdier =
                _opgave21Solution.NumbersAboveOrBelowMinAndMax.ToPrettyString();
            UdsnitAfDeTilfældigeTalUdFraPlaceringIArray = 
                _opgave21Solution.NumbersWithinStartAndEndPosition.ToPrettyString();
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
            get { return _opgave21Solution.StartPosition; }
            set { _opgave21Solution.StartPosition = value; }
        }

        public int UdsnitAfDeTilfældigeTalUdFraPlaceringIArrayTil
        {
            get { return _opgave21Solution.EndPosition; }
            set { _opgave21Solution.EndPosition = value; }
        }

        public string UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdier
        {
            get { return GetFieldWhereDefaultValueIs(""); }
            set { SetField(value); }
        }

        public int UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdierMindsteVærdi
        {
            get { return _opgave21Solution.Min; }
            set { _opgave21Solution.Min = value; }
        }

        public int UdsnitAfDeTilfældigeTalUdFraHøjesteOgMindsteVærdierHøjesteVærdi
        {
            get { return _opgave21Solution.Max; }
            set { _opgave21Solution.Max = value; }
        }

        public int Nummer
        {
            get { return _nummer; }
            set { UpdateNummer(value); }
        }

        private void UpdateNummer(int value)
        {
            _nummer = value;
            AntalForekomsterAfNummer = _opgave21Solution.FindAntal(_opgave21Solution.Numbers, value);
            FøersteForekomstAfNummer = _opgave21Solution.FindForste(_opgave21Solution.Numbers, value);
        }

        public int AntalForekomsterAfNummer
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }

        public int FøersteForekomstAfNummer
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }
    }
}