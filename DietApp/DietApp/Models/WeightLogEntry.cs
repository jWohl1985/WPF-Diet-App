using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Models
{
    public class WeightLogEntry
    {
        // Entity relationships
        public int WeightLogEntryId { get; set; }
        public int UserId { get; set; }
        public int User { get; set; }

        // Properties
        public float WeightRecordedInLbs { get; set; }
        public DateOnly DateRecorded { get; set; }
    }
}
