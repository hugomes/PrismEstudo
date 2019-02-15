using PrismEstudo.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismEstudo.Repositorio
{
    public class ProfissionalRepositorio
    {
            public static List<Profissional> GetListaProfissionais()
            {
                return new List<Profissional>(Realm.GetInstance().All<Profissional>());
            }
    }
}
