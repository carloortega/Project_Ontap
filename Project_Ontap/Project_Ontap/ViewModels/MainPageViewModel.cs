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


            String String_Username = _username;
            String String_Password = _password;

            var Username = await App.Database.GetEmailAddress(String_Username);
            var Password = await App.Database.GetEmailAddress(String_Password);


            if (String_Username.Equals("test"))
            {
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
