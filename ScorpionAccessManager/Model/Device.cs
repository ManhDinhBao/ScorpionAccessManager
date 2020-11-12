using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static ScorpionAccessManager.Model.EDeviceControlMode;

namespace ScorpionAccessManager.Model
{
    public class Device
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MAC { get; set; }
        public string IP { get; set; }
        public string Subnet { get; set; }
        public string Gateway { get; set; }
        public string HostIP { get; set; }
        public bool FAMode { get; set; }
        public int FAHW { get; set; }
        public DeviceControlMode CtrlMode { get; set; }
    }
}
