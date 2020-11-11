using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorpionAccessManager.Model
{
    public class Card: ViewModelBase
    {

        private string serial;

        public string Serial
        {
            get { return serial; }
            set { 
                serial = value;
                RaisePropertyChanged("Serial");
            }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { 
                number = value;
                RaisePropertyChanged("Number");
            }
        }

        private DateTime startTime;

        public DateTime StartTime
        {
            get { return startTime; }
            set { 
                startTime = value;
                RaisePropertyChanged("StartTime");
            }
        }

        private DateTime endTime;

        public DateTime EndTime
        {
            get { return endTime; }
            set { 
                endTime = value;
                RaisePropertyChanged("EndTime");
            }
        }

    }
}
