using PrismEstudo.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismEstudo.Repositorio
{
    public class ComentarioRepositorio
    {
        public static List<Comentario> GetListaProfissionais(Profissional profissional)
        {
            return new List<Comentario>(Realm.GetInstance().All<Comentario>().Where(x=>x.Profissional == profissional));
        }

    }
}
