using FitnessTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Service.Garmin
{
    public interface IGarminStatisticsDataService : IStatisticsDataService
    { }

    public class GarminStatisticsDataService : IGarminStatisticsDataService
    {
   
        IObservable<FitnessStatistics> IStatisticsDataService.GetStatistics(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
