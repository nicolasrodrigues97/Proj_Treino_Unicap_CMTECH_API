using System.ComponentModel.DataAnnotations;

namespace Projeto_CMTECH_UNICAP.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public int? departamento_id { get; set; }
        public int? organizacao_id { get; set; }
        public int perfil_id { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }
        public DateTime data_cadastro { get; set; }
    }
}
