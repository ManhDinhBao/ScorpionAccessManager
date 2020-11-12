using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ScorpionAccessManager.Model.ERightType;

namespace ScorpionAccessManager.Model
{
    public class Schedule
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public RightType RightType { get; set; }
        public string Description { get; set; }
    }
}
