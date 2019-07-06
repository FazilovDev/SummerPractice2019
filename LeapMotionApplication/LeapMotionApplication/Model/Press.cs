using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leap;

namespace LeapMotionApplication.Model
{
    public class Press
    {
        public static long SetId { get; set; } = 1;
        public long Id { get; set; }


        public long Time { get; set; }

        public Press(long time)
        {
            Id = SetId;
            Time = time;
            SetId += 1;
        }

        public Press(Press press)
        {
            Id = press.Id;
            Time = press.Time;
        }
        
        public Press()
        {
            Id = SetId;
            Time = 0;
            SetId += 1;
        }
    }
}
