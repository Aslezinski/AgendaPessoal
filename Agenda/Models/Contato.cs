using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Key]
        public int IdContato { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Apelido { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public TipoDeContato TipoDeContato { get; set; }
    }
}