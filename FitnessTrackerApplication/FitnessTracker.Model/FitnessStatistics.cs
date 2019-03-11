using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Model
{
    public class FitnessStatistics
    {
        public DateTimeOffset StatisticsDate { get; set; }
        public int TotalSteps { get; set; }
        public int Calories { get; set; }
        public int ActiveMinutes { get; set; }
    }
}
