using FitnessTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Service.Fitbit
{
    public interface IFitbitStatisticsDataService : IStatisticsDataService
    { }

    public class FitbitStatisticsDataService : IFitbitStatisticsDataService
    {
        IObservable<FitnessStatistics> IStatisticsDataService.GetStatistics(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
