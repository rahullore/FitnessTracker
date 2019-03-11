using FitnessTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Service.AppleWatch
{
    public interface IAppleWatchStatisticsDataService : IStatisticsDataService
    { }

    public class AppleWatchStatisticsDataService : IAppleWatchStatisticsDataService
    {
        public FitnessStatistics GetStatistics(Person person)
        {
            return null;
        }
    }
}
