using System.ComponentModel.DataAnnotations;

namespace Projeto_CMTECH_UNICAP.Models
{
    public class Departamento
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string organizacao_id { get; set; }
        public string nome { get; set; }
    }
}
