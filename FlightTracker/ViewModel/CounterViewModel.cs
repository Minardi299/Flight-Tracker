using System.Collections.ObjectModel;


namespace FlightTracker.ViewModel
{
    public class CounterViewModel
    {

        private int _currentCount;
        public int CurrentCount
        {
            get => _currentCount;
            set
            {
                _currentCount = value;

            }
        }
        public int Amount { get; set; } = 1;
        public CounterViewModel(int count)
        {
            this.CurrentCount = count;
        }
        public void IncrementCount()
        {
            CurrentCount += Amount;
        }

    }
}
