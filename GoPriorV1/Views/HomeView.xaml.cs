using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoPriorV1.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            Home.HeightRequest = 10000;
            Home.WidthRequest = 10000;
            Home.Source = "https://goprior.com/prior6/";
        }

        //async void OnBackButtonClicked(object sender, EventArgs e)
        //{
        //    if (Home.CanGoBack)
        //    {
        //        Home.GoBack();
        //    }
        //    else
        //    {
        //        await Navigation.PopAsync();
        //    }
        //}

        //void OnForwardButtonClicked(object sender, EventArgs e)
        //{
        //    if (Home.CanGoForward)
        //    {
        //        Home.GoForward();
        //    }
        //}

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
