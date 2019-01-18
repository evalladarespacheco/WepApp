using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoPriorV1.Views.ProgramViews
{
    public partial class SeventhToTwelve : ContentPage
    {
        public SeventhToTwelve()
        {
            InitializeComponent();
            browser.HeightRequest = 10000;
            browser.WidthRequest = 10000;
            browser.Source = "https://goprior.com/prior6/content/robotics-middle-and-high-school-students-7th-12th";
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
