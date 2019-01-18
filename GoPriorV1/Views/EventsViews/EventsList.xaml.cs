using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoPriorV1.Views.EventsViews
{
    public partial class EventsList : ContentPage
    {
        public EventsList()
        {
            InitializeComponent();
            InitializeComponent();
            browser.HeightRequest = 10000;
            browser.WidthRequest = 10000;
            browser.Source = "https://goprior.com/prior6/content/events-list";
        }

        void WebOnNavigating(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            status.Text = "Loading...";
        }

        void WebEndNavigating(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            status.Text = "Done!";
        }

    }
}
