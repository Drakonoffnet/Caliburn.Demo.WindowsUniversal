﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227
using Caliburn.Micro;
using demo.ViewModels;
using demo.Views;

namespace demo
{
    public sealed partial class App
    {
        private WinRTContainer _container;

        public App()
        {
            InitializeComponent();
        }

        protected override void Configure()
        {
            LogManager.GetLog = GetLog;

            MessageBinder.SpecialValues.Add("$clickeditem", c => ((ItemClickEventArgs)c.EventArgs).ClickedItem);
            //MessageBinder.SpecialValues.Add(//"$clickeditem", c => ((ItemClickEventArgs)c.EventArgs).ClickedItem);

            _container = new WinRTContainer();

            _container.RegisterWinRTServices();

            _container.PerRequest<MainPageViewModel>();

            //SettingsService.UserToken = "124123";

            //var str = SettingsService.UserToken;

            //SettingsService.UserToken = "";
        }

        private ILog GetLog(Type type)
        {
            return new DebugLog(type);
        }

        protected override void PrepareViewFirst(Frame rootFrame)
        {
            _container.RegisterNavigationService(rootFrame);
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            //SettingsService.UserToken = null;
            //SettingsService.User = null;

            //var token = SettingsService.UserToken;
            //var user = SettingsService.User;

            //if (args.PreviousExecutionState == ApplicationExecutionState.NotRunning)
            //{
            //    if (token != null)
            //    {
            //        //remove token from store
            //        if (!token.RememberMe)
            //        {
            //            token = null;
            //            user = null;
            //            SettingsService.UserToken = null;
            //            SettingsService.User = null;
            //        }
            //    }
            //}

            //StateService.Instance.UserToken = token;
            //StateService.Instance.User = user;

            if (args.PreviousExecutionState == ApplicationExecutionState.Running)
                return;

            DisplayRootView<MainPage>();

            //DisplayRootView<TestPage>();
        }

        protected override void OnSuspending(object sender, SuspendingEventArgs e)
        {
            base.OnSuspending(sender, e);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }


    //    public sealed partial class App : Application
    //    {
    //#if WINDOWS_PHONE_APP
    //        private TransitionCollection transitions;
    //#endif

    //        /// <summary>
    //        /// Initializes the singleton application object.  This is the first line of authored code
    //        /// executed, and as such is the logical equivalent of main() or WinMain().
    //        /// </summary>
    //        public App()
    //        {
    //            this.InitializeComponent();
    //            this.Suspending += this.OnSuspending;
    //        }

    //        /// <summary>
    //        /// Invoked when the application is launched normally by the end user.  Other entry points
    //        /// will be used when the application is launched to open a specific file, to display
    //        /// search results, and so forth.
    //        /// </summary>
    //        /// <param name="e">Details about the launch request and process.</param>
    //        protected override void OnLaunched(LaunchActivatedEventArgs e)
    //        {
    //#if DEBUG
    //            if (System.Diagnostics.Debugger.IsAttached)
    //            {
    //                this.DebugSettings.EnableFrameRateCounter = true;
    //            }
    //#endif

    //            Frame rootFrame = Window.Current.Content as Frame;

    //            // Do not repeat app initialization when the Window already has content,
    //            // just ensure that the window is active
    //            if (rootFrame == null)
    //            {
    //                // Create a Frame to act as the navigation context and navigate to the first page
    //                rootFrame = new Frame();

    //                // TODO: change this value to a cache size that is appropriate for your application
    //                rootFrame.CacheSize = 1;

    //                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
    //                {
    //                    // TODO: Load state from previously suspended application
    //                }

    //                // Place the frame in the current Window
    //                Window.Current.Content = rootFrame;
    //            }

    //            if (rootFrame.Content == null)
    //            {
    //#if WINDOWS_PHONE_APP
    //                // Removes the turnstile navigation for startup.
    //                if (rootFrame.ContentTransitions != null)
    //                {
    //                    this.transitions = new TransitionCollection();
    //                    foreach (var c in rootFrame.ContentTransitions)
    //                    {
    //                        this.transitions.Add(c);
    //                    }
    //                }

    //                rootFrame.ContentTransitions = null;
    //                rootFrame.Navigated += this.RootFrame_FirstNavigated;
    //#endif

    //                // When the navigation stack isn't restored navigate to the first page,
    //                // configuring the new page by passing required information as a navigation
    //                // parameter
    //                if (!rootFrame.Navigate(typeof(MainPage), e.Arguments))
    //                {
    //                    throw new Exception("Failed to create initial page");
    //                }
    //            }

    //            // Ensure the current window is active
    //            Window.Current.Activate();
    //        }

    //#if WINDOWS_PHONE_APP
    //        /// <summary>
    //        /// Restores the content transitions after the app has launched.
    //        /// </summary>
    //        /// <param name="sender">The object where the handler is attached.</param>
    //        /// <param name="e">Details about the navigation event.</param>
    //        private void RootFrame_FirstNavigated(object sender, NavigationEventArgs e)
    //        {
    //            var rootFrame = sender as Frame;
    //            rootFrame.ContentTransitions = this.transitions ?? new TransitionCollection() { new NavigationThemeTransition() };
    //            rootFrame.Navigated -= this.RootFrame_FirstNavigated;
    //        }
    //#endif

    //        /// <summary>
    //        /// Invoked when application execution is being suspended.  Application state is saved
    //        /// without knowing whether the application will be terminated or resumed with the contents
    //        /// of memory still intact.
    //        /// </summary>
    //        /// <param name="sender">The source of the suspend request.</param>
    //        /// <param name="e">Details about the suspend request.</param>
    //        private void OnSuspending(object sender, SuspendingEventArgs e)
    //        {
    //            var deferral = e.SuspendingOperation.GetDeferral();

    //            // TODO: Save application state and stop any background activity
    //            deferral.Complete();
    //        }
    //    }
}