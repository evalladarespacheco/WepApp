using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoPriorV1.Views.ContactUsViews
{
    public partial class Sponsors : ContentPage
    {
        public Sponsors()
        {
            InitializeComponent();
            browser.HeightRequest = 10000;
            browser.WidthRequest = 10000;
            browser.Source = "https://goprior.com/prior6/content/sponsors";
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
