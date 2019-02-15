using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismEstudo.Models;
using PrismEstudo.Repositorio;
using PrismEstudo.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismEstudo.ViewModels
{
	public class ListaProfissionaisViewModel : BindableBase
	{
        private INavigationService _navigationService;
        private List<Profissional> _listaProfissionais { get; set; }
        public List<Profissional> ListaProfissionais
        {
            get { return _listaProfissionais; }
            set { _listaProfissionais = value; }
        }

        public DelegateCommand<Profissional> ItemProfissionalTappedCommand { get; set; }

        public ListaProfissionaisViewModel(INavigationService navigationService)
        {
            ListaProfissionais = ProfissionalRepositorio.GetListaProfissionais();
            ItemProfissionalTappedCommand = new DelegateCommand<Profissional>(ItemProfissional);
            _navigationService = navigationService;
        }

        private void ItemProfissional(Profissional profissional)
        {
            NavigationParameters navigationParameter = new NavigationParameters();
            navigationParameter.Add("profissional", profissional);
            _navigationService.NavigateAsync("DetalhesProfissional", navigationParameter);
        }
	}
}
