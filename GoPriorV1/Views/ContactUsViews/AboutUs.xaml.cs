using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoPriorV1.Views.ContactUsViews
{
    public partial class AboutUs : ContentPage
    {
        public AboutUs()
        {
            InitializeComponent();
            browser.HeightRequest = 10000;
            browser.WidthRequest = 10000;
            browser.Source = "https://goprior.com/prior6/content/about-us-1";
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
