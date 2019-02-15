using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismEstudo.Models;
using PrismEstudo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismEstudo.ViewModels
{
	public class DetalhesProfissionalViewModel : BindableBase, INavigatingAware
	{
        private Profissional _profissional;
        public Profissional Profissional
        {
            get { return _profissional; }
            set { SetProperty(ref _profissional, value); }
        }

        private List<Comentario> _comentarios;
        public List<Comentario> Comentarios
        {
            get { return _comentarios; }
            set { SetProperty(ref _comentarios, value); }
        }

        public DetalhesProfissionalViewModel()
        {

        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("profissional"))
            {
                Profissional = parameters.GetValue<Profissional>("profissional");
                Comentarios = ComentarioRepositorio.GetListaProfissionais(Profissional);
            }
        }
    }
}
