using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class BodyMeasurements
    {
        // Entity relationships
        public int BodyMeasurementsId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        // Measurement properties
        public float Neck { get; set; }
        public float Waist { get; set; }
        public float Hips { get; set; }

        public BodyMeasurements(float neck, float waist, float hips)
        {
            this.Neck = neck;
            this.Waist = waist;
            this.Hips = hips;
        }

        public BodyMeasurements()
        {

        }
    }
}
