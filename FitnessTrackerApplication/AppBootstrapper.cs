using FitnessTracker.Service;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerApplication
{
    public class AppBootstrapper: IEnableLogger
    {
        public AppBootstrapper()
        {

        }

        public void RegisterViews()
        {

        }

        public void RegisterViewModels()
        {

        }

        public void RegisterServices()
        {
            Locator.CurrentMutable.RegisterLazySingleton<IFitbitStatisticsDataService>(() => new FakeFitbitStatisticsDataService());
        }
    }
}
