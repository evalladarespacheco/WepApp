using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoPriorV1.Views.ContactUsViews
{
    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();
            browser.HeightRequest = 10000;
            browser.WidthRequest = 10000;
            browser.Source = "https://goprior.com/prior6/content/contact-us";
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
