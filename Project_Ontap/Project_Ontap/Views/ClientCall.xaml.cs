using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Ontap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientCall : ContentPage
    {
        public ClientCall()
        {
            InitializeComponent();

            ContactPerson.Items.Add("Andrew Javier");
            ContactPerson.Items.Add("Harold Balano");
            ContactPerson.Items.Add("Eugene Santos");
            ContactPerson.Items.Add("Jiven Tabien");
            ContactPerson.Items.Add("Joshua Jerezo");

            ClientStatus.Items.Add("Completed");
            ClientStatus.Items.Add("Missed");
        }
    }
}