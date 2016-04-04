using System;

namespace GP.Opgavesaet2.Opgave2_1
{
    public class Opgave21
    {
        private int _startPosition;
        private int _endPosition;
        private int _min;
        private int _max;

        public Opgave21()
        {
            Numbers = GetThisAmountOfRandomNumbers(50);

            NumbersReversed = Numbers.Reversed();

            StartPosition = 0;
            EndPosition = Numbers.Length - 1;
            UpdateNumbersWithinStartAndEndPosition();

            Min = int.MinValue;
            Max = int.MaxValue;
            UpdateNumbersAboveOrBelowMinAndMax();
        }

        private int[] GetThisAmountOfRandomNumbers(int amount)
        {
            var random = new Random();
            var numbers = new int[amount];
            for (var i = 0; i < amount; i++)
            {
                numbers[i] = random.Next(-10, 21);
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

        public event EventHandler SomethingChanged;

        private void InvokeSomethingChanged()
        {
            SomethingChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}