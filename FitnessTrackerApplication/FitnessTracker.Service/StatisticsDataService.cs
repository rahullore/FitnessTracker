using FitnessTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Service
{
    public interface IStatisticsDataService: IServiceBase
    {
        IObservable<FitnessStatistics> GetStatistics(Person person);
    }
}
