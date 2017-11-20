using System;
using Xamarin.Forms;

namespace Project_Ontap.Views
{
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();
        }

        private void Goto_Target(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutVersion());
        }

        private void Goto_Clients(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClientCall());
        }

        private void Goto_Performance(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutVersion());
        }

        private void Goto_Summary(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutVersion());
        }
    }
}
