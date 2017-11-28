using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Ontap.ViewModels
{
    public class HomePageViewModel : BindableBase
    {

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _fullname;
        public string Fullname
        {
            get => _fullname;
            set => SetProperty(ref _fullname, value);
        }

        public HomePageViewModel()
        {
            Username = App.Current.Properties["Email"].ToString();
            Fullname = App.Current.Properties["Fullname"].ToString();
        }
    }
}
