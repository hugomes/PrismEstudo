using Realms;
using System;

namespace PrismEstudo.Models
{
    public class Comentario : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public Profissional Profissional { get; set; }
        public string Autor { get; set; }
        public DateTimeOffset Data { get; set; }
        public string Descricao { get; set; }
    }
}
