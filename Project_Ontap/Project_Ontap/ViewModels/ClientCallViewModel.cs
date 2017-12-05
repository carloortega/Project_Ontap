using Microcharts;
using Prism.Commands;
using Prism.Mvvm;
using Project_Ontap.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Ontap.ViewModels
{
    public class ClientCallViewModel : BindableBase
    {

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

        //private async void GetClientContacts()
        //{

        //    var getClientContacts = await App.Database.GetClientContacts();
        //    List<TClientContacts> ContactList = new List<TClientContacts>();

        //    foreach (var item in getClientContacts)
        //    {
        //        var contact = ContactList.Where(i => i.ContactPerson == item.ContactPerson).ToList();
        //        if(contact.Count == 0)
        //        {
        //            ContactList.Add(item);
        //        }
        //    }

        //}

        public ClientCallViewModel()
        {
            ClientName = App.Current.Properties["ClientName"].ToString();
            Target = App.Current.Properties["ClientTarget"].ToString();
            Completed = App.Current.Properties["ClientCompleted"].ToString();
            ChartData = PerformanceChart;
        }
    }
}
