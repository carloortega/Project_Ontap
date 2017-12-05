using Microcharts;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Ontap.ViewModels
{
	public class ClientSummaryViewModel : BindableBase
	{
        INavigationService _navigationService;

        private string _clientname;
        public string ClientName
        {
            get => _clientname;
            set => SetProperty(ref _clientname, value);
        }

        private string _target;
        public string Target
        {
            get => _target;
            set => SetProperty(ref _target, value);
        }

        private string _completed;
        public string Completed
        {
            get => _completed;
            set => SetProperty(ref _completed, value);
        }

        private string _missed;
        public string Missed
        {
            get => _missed;
            set => SetProperty(ref _missed, value);
        }

        private string _lastcoveredon;
        public string LastCoveredOn
        {
            get => _lastcoveredon;
            set => SetProperty(ref _lastcoveredon, value);
        }

        public DelegateCommand ClientCall => new DelegateCommand(GoTo_ClientCall);
        public DelegateCommand ClientList => new DelegateCommand(GoTo_ClientList);

        public Chart ChartData { get; set; }

        public Chart PerformanceChart => new RadialGaugeChart()
        {
            Entries = new[]
            {
             new Microcharts.Entry(Convert.ToInt32(Target))
             {
                Color = SKColors.Transparent,
             },
             new Microcharts.Entry(Convert.ToInt32(Completed))
             {
                Color = SKColor.Parse("#1cb31a"),
             }},
            BackgroundColor = SKColors.Transparent

        };

        private async void GetClientTarget()
        {

            var getClientName = await App.Database.GetClientName();
            string client = getClientName[0].ClientName.ToString();
            ClientName = client;
            App.Current.Properties["ClientName"] = ClientName;

            var getMissedCall = await App.Database.GetMissedCallCount();
            int missed = getMissedCall.Count;
            Missed = missed.ToString();

            var getLastCoveredOn = await App.Database.GetMaxClientCall();
            string lastcoveredon = getLastCoveredOn[0].ClientCallDate.ToString();
            LastCoveredOn = lastcoveredon;

        }

        public ClientSummaryViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GetClientTarget();

            Target = App.Current.Properties["ClientTarget"].ToString();
            Completed = App.Current.Properties["ClientCompleted"].ToString();
            ChartData = PerformanceChart;
        }

        private async void GoTo_ClientCall()
        {
            await _navigationService.NavigateAsync("/NavigationPage/ClientCall");
        }


        private async void GoTo_ClientList()
        {
            await _navigationService.NavigateAsync("/NavigationPage/ClientList");
        }

    }
}
