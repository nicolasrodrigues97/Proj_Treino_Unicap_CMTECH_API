using System.ComponentModel.DataAnnotations;

namespace Projeto_CMTECH_UNICAP.Models
{
    public class Atendimento
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int status_atendimento_id { get; set; }
        public int departamento_id { get; set; }
        public int usuario_id { get; set; }
        public int cliente_id { get; set; }
        public int organizacao_id { get; set; }
        public DateTime data_hora_atendimento { get; set; }
    }
}
