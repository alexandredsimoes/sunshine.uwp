using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using Sunshine.UWP.Models;
using Sunshine.UWP.Services;

namespace Sunshine.UWP.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IApiService _apiService;
        private ObservableCollection<Previsao> _previsoes;

        public MainPageViewModel(IApiService apiService)
        {
            _apiService = apiService;
        }

        public override async void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            Previsoes = new ObservableCollection<Previsao>(await _apiService.ListarPrevisoes());                        
        }

        public ObservableCollection<Previsao> Previsoes
        {
            get { return _previsoes; }
            set { SetProperty(ref _previsoes , value); }
        }
    }
}