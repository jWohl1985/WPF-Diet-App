using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class BodyMeasurements
    {
        public float Neck { get; private set; }
        public float Waist { get; private set; }
        public float Hips { get; private set; }

        public BodyMeasurements(float neck, float waist, float hips)
        {
            this.Neck = neck;
            this.Waist = waist;
            this.Hips = hips;
        }
    }
}
