using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GoPriorV1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GoPriorV1.MainPage();
        }

    }
}
