using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Project_Ontap.Data;
using Project_Ontap.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Project_Ontap.ViewModels
{
	public class ClientListViewModel : BindableBase, INavigationAware
    {

        private List<TClient> _recordsList;
        public List<TClient> RecordsList
        {
            get { return _recordsList; }
            set { SetProperty(ref _recordsList, value); }
        }

        protected INavigationService NavigationService { get; private set; }

        public ClientListViewModel(INavigationService navigationService)
        {
            PopulateList();
        }

        public async void PopulateList()
        {
            RecordsList = new List<TClient>();
            var list = await App.Database.GetItemsAsync();

            foreach(var a in list)
            {
                RecordsList.Add(new TClient { ClientID = a.ClientID, ClientName = a.ClientName });
            }
            
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public async void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
