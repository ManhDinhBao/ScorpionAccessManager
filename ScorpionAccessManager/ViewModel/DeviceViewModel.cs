using GalaSoft.MvvmLight;
using ScorpionAccessManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ScorpionAccessManager.ViewModel
{
    public class DeviceViewModel:ViewModelBase
    {
        private ObservableCollection<Device> devices;

        public ObservableCollection<Device> Devices
        {
            get
            {
                return devices;
            }
            set
            {
                devices = value;
                RaisePropertyChanged("Devices");
            }
        }

        private ListCollectionView _view;
        public ICollectionView View
        {
            get { return this._view; }
        }

        private string _textSearch;

        public string TextSearch
        {
            get { return _textSearch; }
            set
            {
                _textSearch = value;
                RaisePropertyChanged("TextSearch");

                if (String.IsNullOrEmpty(value))
                    View.Filter = null;
                else
                    View.Filter = new Predicate<object>(o => ((Device)o).Name == value);
            }
        }


        public DeviceViewModel()
        {
            devices = new ObservableCollection<Device>
            {
                new Device{Id="DV01",Name="Device 01",MAC="00-FF-59-65-EE-6A",IP="192.168.1.100",Subnet="255.255.255.0",Gateway="192.168.1.1",HostIP="192.168.1.10",FAMode=true,FAHW=1,CtrlMode=EDeviceControlMode.DeviceControlMode.CONTROL_DOOR},
                new Device{Id="DV02",Name="Device 02",MAC="00-FF-59-65-EE-6B",IP="192.168.1.101",Subnet="255.255.255.0",Gateway="192.168.1.1",HostIP="192.168.1.10",FAMode=false,FAHW=0,CtrlMode=EDeviceControlMode.DeviceControlMode.CONTROL_DOOR},
                new Device{Id="DV03",Name="Device 03",MAC="00-FF-59-65-EE-6C",IP="192.168.1.102",Subnet="255.255.255.0",Gateway="192.168.1.1",HostIP="192.168.1.10",FAMode=true,FAHW=1,CtrlMode=EDeviceControlMode.DeviceControlMode.CONTROL_ELEVATOR}
            };

            this._view = new ListCollectionView(this.devices);
        }
    }
}
