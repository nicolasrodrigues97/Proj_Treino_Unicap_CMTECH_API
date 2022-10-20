using System.ComponentModel.DataAnnotations;

namespace Projeto_CMTECH_UNICAP.Models
{
    public class Perfil
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
    }
}
