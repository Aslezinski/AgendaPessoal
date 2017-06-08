using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    [Table ("TipoDeContato")]
    public class TipoDeContato
    {
        [Key]
        public int IdTipoDeContato { get; set; }

        public string Descricao { get; set; }
    }
}