using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Project_Ontap.Views
{
    public partial class HomePage : MasterDetailPage
    {

        public HomePage()
        {
            InitializeComponent();

            var menulist = new List<MenuItem.MenuItem>();

            var target = new MenuItem.MenuItem()
            {
                Title = "T a r g e t",
                Icon = "target.png",
                TargetType = typeof(TargetCall)
            };

            var clients = new MenuItem.MenuItem()
            {
                Title = "C l i e n t s",
                Icon = "clients.png",
                TargetType = typeof(ClientCall)
            };

            var performance = new MenuItem.MenuItem()
            {
                Title = "P e r f o r m a n c e",
                Icon = "performance.png",
                TargetType = typeof(Performance)
            };

            var summary = new MenuItem.MenuItem()
            {
                Title = "S u m m a r y",
                Icon = "summary.png",
                TargetType = typeof(CallsSummary)
            };

            var settings = new MenuItem.MenuItem()
            {
                Title = "S e t t i n g s",
                Icon = "settings.png",
                TargetType = typeof(About)
            };

            var about = new MenuItem.MenuItem()
            {
                Title = "A b o u t",
                TargetType = typeof(AboutVersion)
            };

            var logout = new MenuItem.MenuItem()
            {
                Title = "L o g o u t",
                TargetType = typeof(MainPage)
            };

            menulist.Add(target);
            menulist.Add(clients);
            menulist.Add(performance);
            menulist.Add(summary);
            menulist.Add(settings);
            menulist.Add(about);
            menulist.Add(logout);


            listView.ItemsSource = menulist;

        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuItem.MenuItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

    }
}