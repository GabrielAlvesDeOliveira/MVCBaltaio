using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baltaio.Models
{
    public class Todo
    {
        public int Id {get; set;}
        [DisplayName("Título")]
        [Required(ErrorMessage = "campo obrigatório")]
        public string Title {get; set;}
        [DisplayName("Concluído")]
        public bool Done {get; set;}
        [DisplayName("Criado em")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        [DisplayName("Última atualização")]
        public DateTime LastUpdatedAt {get; set;} = DateTime.Now;
        public string User {get; set;}
    }
}