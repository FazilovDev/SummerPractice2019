using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leap;

namespace LeapMotionApplication.Model
{
    public class PressMotion
    {
        public static long SetId { get; set; } = 1;
        public long Id { get; set; }
        public string NameFinger { get; set; }
        public List<float> TipVelocity { get; set; }
        public long TimePress { get; set; }

        public PressMotion(string nameFinger, Vector tipVelocity, long timePress)
        {
            Id = SetId;
            NameFinger = nameFinger;
            TipVelocity = new List<float> { tipVelocity.x, tipVelocity.y, tipVelocity.z };
            TimePress = timePress;
            SetId += 1;
        }

        public PressMotion(PressMotion press)
        {
            Id = press.Id;
            NameFinger = press.NameFinger;
            TipVelocity = press.TipVelocity;
            TimePress = press.TimePress;
        }

        public PressMotion( string nameFinger, List<float> tipVelocity, long timePress)
        {
            Id = SetId;
            NameFinger = nameFinger;
            TipVelocity = tipVelocity;
            TimePress = timePress;
            SetId += 1;
        }

        public PressMotion()
        {
            Id = SetId;
            NameFinger = "";
            TipVelocity = new List<float> { 0, 0, 0 };
            TimePress = 0;
            SetId += 1;
        }
    }
}
