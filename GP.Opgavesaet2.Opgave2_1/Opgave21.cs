using System;

namespace GP.Opgavesaet2.Opgave2_1
{
    public class Opgave21
    {
        private int _startPosition;
        private int _endPosition;
        private int _min;
        private int _max;
        private int _number;

        public Opgave21()
        {
            Numbers = GetThisAmountOfRandomNumbers(50);

            NumbersReversed = Numbers.Reversed();

            StartPosition = 0;
            EndPosition = Numbers.Length - 1;
            UpdateNumbersWithinStartAndEndPosition();

            Min = 0;
            Max = 50;
            UpdateNumbersAboveOrBelowMinAndMax();
        }

        private int[] GetThisAmountOfRandomNumbers(int amount)
        {
            var random = new Random();
            var numbers = new int[amount];
            for (var i = 0; i < amount; i++)
            {
                numbers[i] = random.Next(0, 100);
            }
            return numbers;
        }

        public int[] Numbers { get; }
        public int[] NumbersReversed { get; }
        public int[] NumbersWithinStartAndEndPosition { get; private set; }
        public int[] NumbersAboveOrBelowMinAndMax { get; private set; }

        public int StartPosition
        {
            get { return _startPosition; }
            set { UpdateStartPosition(value); }
        }

        private void UpdateStartPosition(int value)
        {
            _startPosition = value;
            UpdateNumbersWithinStartAndEndPosition();
        }

        public int EndPosition
        {
            get { return _endPosition; }
            set { UpdateEndPosition(value); }
        }

        private void UpdateEndPosition(int value)
        {
            _endPosition= value;
            UpdateNumbersWithinStartAndEndPosition();
        }


        private void UpdateNumbersWithinStartAndEndPosition()
        {
            NumbersWithinStartAndEndPosition = Numbers.SubArray(StartPosition, EndPosition - StartPosition + 1);
            InvokeSomethingChanged();
        }

        public int Min
        {
            get { return _min; }
            set { UpdateMin(value); }
        }

        private void UpdateMin(int value)
        {
            _min = value;
            UpdateNumbersAboveOrBelowMinAndMax();
        }

        public int Max
        {
            get { return _max; }
            set { UpdateMax(value); }
        }

        private void UpdateMax(int value)
        {
            _max = value;
            UpdateNumbersAboveOrBelowMinAndMax();
        }

        private void UpdateNumbersAboveOrBelowMinAndMax()
        {
            NumbersAboveOrBelowMinAndMax = Numbers.OnlyAboveOrBelowMinAndMax(Min, Max);
            InvokeSomethingChanged();
        }

        public Int32 FindAntal(Int32[] tabel, Int32 tal)
        {
            return tabel.OccurrencesOf(tal);
        }

        public Int32 FindForste(Int32[] tabel, Int32 tal)
        {
            try
            {
                return tabel.FirstPositionOf(tal);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int PositionOfFirstOccuranceOfNumber { get; private set; } = -1;
        public int NumberOfOccurancesOfNumber { get; private set; } = -1;

        public event EventHandler SomethingChanged;

        private void InvokeSomethingChanged()
        {
            SomethingChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}