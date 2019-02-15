using Realms;
using System;
using System.Collections.Generic;

namespace PrismEstudo.Models
{
    public class Profissional : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Nome { get; set; }
        public string ImagemPerfil { get; set; }
        public string Especialidade { get; set; }
        public string Descricao { get; set; }

        public List<Comentario> Comentarios { get; }
    }
}
