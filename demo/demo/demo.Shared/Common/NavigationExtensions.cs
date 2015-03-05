using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Caliburn.Micro;

namespace demo.Common
{
    public static class NavigationExtensions
    {
        public static void CleanNavigationStackAfter(this INavigationService ns)
        {
            ns.Navigated += NsOnNavigated;

            ns.NavigationFailed += NsOnNavigationFailed;

            ns.NavigationStopped += NsOnNavigationStopped;
        }

        private static void Unsubscribe(object n)
        {
            var ns = (Frame)n;
            ns.Navigated -= NsOnNavigated;
            ns.NavigationFailed -= NsOnNavigationFailed;
            ns.NavigationStopped -= NsOnNavigationStopped;
        }

        private static void NsOnNavigated(object sender, NavigationEventArgs navigationEventArgs)
        {
            Unsubscribe(sender);

            var ns = (Frame)sender;

            while (ns.CanGoBack)
            {
                ns.BackStack.Clear();
            }
        }


        private static void NsOnNavigationStopped(object sender, NavigationEventArgs navigationEventArgs)
        {
            Unsubscribe(sender);
        }

        private static void NsOnNavigationFailed(object sender, NavigationFailedEventArgs navigationFailedEventArgs)
        {
            Unsubscribe(sender);
        }


        //public static void ToLoginPage(this INavigationService ns, bool backOnSucsseful = false)
        //{
        //    ns.UriFor<AuthPageViewModel>().WithParam(x => x.BackOnSuccefulLogin, backOnSucsseful).Navigate();
        //}

        //public static void ToSearchPage(this INavigationService ns, string searchString = "")
        //{
        //    ns.UriFor<SearchPageViewModel>().WithParam(x => x.SearchText, searchString).Navigate();
        //}
    }
}
