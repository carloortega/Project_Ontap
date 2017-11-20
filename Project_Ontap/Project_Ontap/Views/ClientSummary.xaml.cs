using Xamarin.Forms;

namespace Project_Ontap.Views
{
    public partial class ClientSummary : ContentPage
    {
        public ClientSummary()
        {
            InitializeComponent();
        }

        private void GoTo_ClientCall(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ClientCall());
        }
    }
}
