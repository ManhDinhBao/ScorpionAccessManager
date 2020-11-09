using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorpionAccessManager.Model
{
    public class Card: INotifyPropertyChanged
    {
        private string serial;

        public string Serial
        {
            get { return serial; }
            set 
            { 
                serial = value;
                OnPropertyChanged("Serial");
            }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set 
            { 
                number = value;
                OnPropertyChanged("Number");
            }
        }

        private DateTime startTime;

        public DateTime StartTime
        {
            get { return startTime; }
            set 
            { 
                startTime = value;
                OnPropertyChanged("StartTime");
            }
        }

        private DateTime endTime;

        public DateTime EndTime
        {
            get { return endTime; }
            set 
            { 
                endTime = value;
                OnPropertyChanged("EndTime");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
