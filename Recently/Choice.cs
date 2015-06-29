using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recently
{
    public class Choice
    {
        public DateTime LastPicked { get; set; }

        public int TimesPicked { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public Choice()
        {
            this.TimesPicked = 0;
            this.LastPicked = DateTime.MinValue;
        }
    }
}
