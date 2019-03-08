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
        FitnessStatistics GetStatistics(Person person);
    }


    public interface IFitbitStatisticsDataService : IStatisticsDataService
    { }
    public class FitbitStatisticsDataService: IFitbitStatisticsDataService
    {
        public FitnessStatistics GetStatistics(Person person)
        {
            return null;
        }
    }
    public class FakeFitbitStatisticsDataService : IFitbitStatisticsDataService
    {
        public FitnessStatistics GetStatistics(Person person)
        {
            return null;
        }
    }


    public interface IAppleWatchStatisticsDataService : IStatisticsDataService
    { }
    public class AppleWatchStatisticsDataService : IAppleWatchStatisticsDataService
    {
        public FitnessStatistics GetStatistics(Person person)
        {
            return null;
        }
    }


    public interface IGarminStatisticsDataService : IStatisticsDataService
    { }
    public class GerminStatisticsDataService : IGarminStatisticsDataService
    {
        public FitnessStatistics GetStatistics(Person person)
        {
            return null;
        }
    }
}
