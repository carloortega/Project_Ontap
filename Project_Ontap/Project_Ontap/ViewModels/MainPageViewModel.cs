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

        public DelegateCommand NavigationCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            NavigationCommand = new DelegateCommand(Navigate);
        }

        private async void Navigate()
        {
            await _navigationService.NavigateAsync("/HomePage/NavigationPage/About");
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
