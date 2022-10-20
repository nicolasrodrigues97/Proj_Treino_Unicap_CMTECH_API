using System.ComponentModel.DataAnnotations;

namespace Projeto_CMTECH_UNICAP.Models
{
    public class Organizacao
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int segmento_id { get; set; }
        public int grupo_id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
    }
}
