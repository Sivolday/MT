using System.Diagnostics;
using System.Windows;

namespace MT.SharedComponents
{
    public class PerformanceTester : ViewModelBase
    {
        public double Time
        {
            get => _time;
            private set { _time = value; RaisePropertyChanged();}
        }

        private Stopwatch _watch;
        private double _time;

        public void Start()
        {
            _watch = Stopwatch.StartNew();
        }

        public void Stop()
        {
            _watch.Stop();
            Time = _watch.ElapsedMilliseconds;
        }
    }
}
