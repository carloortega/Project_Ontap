using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Ontap.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        INavigationService _navigationService;
        private string _title = "MainPage";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public DelegateCommand NavigationCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
        {
                _navigationService = navigationService;
                NavigationCommand = new DelegateCommand(Navigate);

        }

        private async void Navigate()
        {
            
            //var Username = await App.Database.GetEmailAddress(_username);
            var Password = await App.Database.GetAccount(_username, _password);
            var UserDetails = await App.Database.GetUserDetails(_username);

            if (_username == null && _password == null)
            {
                await App.Current.MainPage.DisplayActionSheet("Username and Password required", "Ok", "");
            }
            else if (_username == null || _password == null)
            {
                await App.Current.MainPage.DisplayActionSheet("Username or Password required","Ok","");
            }
            else if (Password == null)
            {
                await App.Current.MainPage.DisplayActionSheet("Username or Password did not match", "Ok", "");
            }
            else if (Password != null)
            {
                App.Current.Properties["Email"] = UserDetails.EmailAddress;
                App.Current.Properties["Fullname"] = UserDetails.FirstName + " " + UserDetails.LastName;
                await _navigationService.NavigateAsync("/HomePage/NavigationPage/About");
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //if (parameters.ContainsKey("title"))
            //    Title = (string)parameters["title"] + " and Prism";
        }
    }
}
