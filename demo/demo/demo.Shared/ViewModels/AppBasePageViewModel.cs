using System;
using System.Collections.Generic;
using System.Text;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Media;
using Caliburn.Micro;

namespace demo.ViewModels
{
    public class AppBasePageViewModel : Screen
    {
        protected readonly INavigationService NavigationService;

        public AppBasePageViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;
        }


        protected override void OnActivate()
        {
            base.OnActivate();
        }

        #region Props


        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }

            set
            {
                if (isBusy != value)
                {
                    isBusy = value;
                    NotifyOfPropertyChange();
                }
            }
        }

        #endregion
    }
}
