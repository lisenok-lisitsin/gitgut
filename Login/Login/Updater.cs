using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Updater : INotifyPropertyChanged
    {
        private double myNumber;
        public double MyNumber
        {
            get { return myNumber; }
            set
            {
                if (myNumber != value)
                {
                    myNumber = value;
                    OnPropertyChanged("MyNumber");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
