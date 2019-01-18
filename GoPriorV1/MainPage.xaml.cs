using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoPriorV1.MenuItem;
using GoPriorV1.Views;
using GoPriorV1.Views.ContactUsViews;
using GoPriorV1.Views.EventsViews;
using GoPriorV1.Views.GalleryViews;
using GoPriorV1.Views.NewsViews;
using GoPriorV1.Views.ProgramViews;
using GoPriorV1.Views.ShopViews;
using GoPriorV1.Views.SupportViews;
using Xamarin.Forms;

namespace GoPriorV1
{
    public partial class MainPage : MasterDetailPage
    {
        public List<PageItems> menuList { get; set; }

        public MainPage()
        {

            InitializeComponent();

            menuList = new List<PageItems>();
           
            var page0 = new PageItems() { Title = "Home", Icon = "https://img.icons8.com/ios/50/000000/home-page-filled.png", TargetType = typeof(HomeView) };
            var page1 = new PageItems() { Title = "Programs", Icon = "https://img.icons8.com/ios/50/000000/sandbox-filled.png", TargetType = typeof(ProgramTabs) };
            var page2 = new PageItems() { Title = "Events", Icon = "https://img.icons8.com/ios/50/000000/event-accepted-filled.png", TargetType = typeof(EventsTabs) };
            var page3 = new PageItems() { Title = "Shop", Icon = "https://img.icons8.com/ios/50/000000/shopping-cart-filled.png", TargetType = typeof(ShopTabs) };
            var page4 = new PageItems() { Title = "News", Icon = "https://img.icons8.com/ios/50/000000/news-filled.png", TargetType = typeof(News) };
            var page5 = new PageItems() { Title = "Modern Gallery", Icon = "https://img.icons8.com/ios/50/000000/picture-filled.png", TargetType = typeof(GalleryTabs) };
            var page6 = new PageItems() { Title = "Support", Icon = "https://img.icons8.com/ios/50/000000/help-filled.png", TargetType = typeof(SupportTabs) };
            var page7 = new PageItems() { Title = "Contact Us", Icon = "https://img.icons8.com/ios/50/000000/user-group-man-man-filled.png", TargetType = typeof(ContactUsTabs) };

            // Adding menu items to menuList
            menuList.Add(page0);
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomeView)));
            this.BindingContext = new
            {
                Header = "",
                Image = "",
                Footer = "Welcome To GoPrior"
            };
        }



        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (PageItems)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }

}

