using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoPriorV1.Views.ProgramViews
{
    public partial class FourthToSix : ContentPage
    {
        public FourthToSix()
        {
            InitializeComponent();
            browser.HeightRequest = 10000;
            browser.WidthRequest = 10000;
            browser.Source = "https://goprior.com/prior6/content/robotics-elementary-students-4th-6th";
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
