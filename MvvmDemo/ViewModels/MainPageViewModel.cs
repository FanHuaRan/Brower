﻿using System;
using System.Windows;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using SimpleMvvmToolkit;

// Toolkit extension methods
using SimpleMvvmToolkit.ModelExtensions;

namespace MvvmDemo
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class MainPageViewModel : ViewModelBase<MainPageViewModel>
    {
        #region Initialization and Cleanup

        // Default ctor
        public MainPageViewModel() { }

        #endregion

        #region Notifications

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties

        // Add properties using the mvvmprop code snippet

        private string bannerText = "Hello Simple MVVM Toolkit";
        public string BannerText
        {
            get
            {
                if (this.IsInDesignMode()) return "Banner";
                return bannerText;
            }
            set
            {
                bannerText = value;
                NotifyPropertyChanged(m => m.BannerText);
            }
        }

        #endregion

        #region Methods

        // TODO: Add methods that will be called by the view

        #endregion

        #region Completion Callbacks

        // TODO: Optionally add callback methods for async calls to the service agent

        #endregion

        #region Helpers

        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }

        #endregion
    }
}