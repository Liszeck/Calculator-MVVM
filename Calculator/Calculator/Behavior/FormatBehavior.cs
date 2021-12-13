using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Calculator.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator.Behaviour
{
    class FormatBehavior : INotifyPropertyChanged
    {
        private int clickCount;

        public int ClickCount
        {
            get => clickCount;
            set
            {
                clickCount = value;
                NotifyPropertyChanged();
            }
        }
        public Command ClickCommand { get; set; }
        public FormatBehavior()
        {
            ClickCommand = new Command(() => ClickCount++);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
