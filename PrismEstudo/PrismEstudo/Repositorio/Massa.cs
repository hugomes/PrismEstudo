using PrismEstudo.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismEstudo.Repositorio
{
    public class Massa
    {
        public static void CriarMassaDados()
        {
            var realm = Realm.GetInstance();

            if (!realm.All<Profissional>().Any())
                realm.Write(() =>
                {
                    for (var i = 0; i < 19; i++)
                    {
                        Profissional profissional = new Profissional
                        {
                            Nome = "Prof " + i,
                            Descricao = "Descricao " + i,
                            Especialidade = "Especialidade " + i,
                            ImagemPerfil = "https://i1.wp.com/www.rivermedcenter.net/wp-content/uploads/2017/02/profile-img.jpg"
                        };

                        realm.Add<Profissional>(profissional);

                        for(var j = 0; j < 3; j++)
                        {
                            Comentario comentario = new Comentario()
                            {
                                Autor = string.Format("Autor {0} {1}", i, j),
                                Data = DateTime.Now,
                                Descricao = string.Format("Descricao {0} {1}", i, j),
                                Profissional = profissional,
                            };

                            realm.Add<Comentario>(comentario);
                        }
                    }
                });
        }
    }
}
