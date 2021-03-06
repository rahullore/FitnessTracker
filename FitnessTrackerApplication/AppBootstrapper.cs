﻿using FitnessTracker.Service.AppleWatch;
using FitnessTracker.Service.Fitbit;
using FitnessTracker.Service.Garmin;
using Splat;

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
            Locator.CurrentMutable.RegisterConstant(new FitbitStatisticsDataService(),typeof(IFitbitStatisticsDataService));
            Locator.CurrentMutable.RegisterConstant(new AppleWatchStatisticsDataService(), typeof(IAppleWatchStatisticsDataService));
            Locator.CurrentMutable.RegisterConstant(new GarminStatisticsDataService(), typeof(IGarminStatisticsDataService));
        }
    }
}
