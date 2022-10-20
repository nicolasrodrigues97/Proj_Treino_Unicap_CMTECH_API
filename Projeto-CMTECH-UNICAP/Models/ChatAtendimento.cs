using System.ComponentModel.DataAnnotations;

namespace Projeto_CMTECH_UNICAP.Models
{
    public class ChatAtendimento
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int atendimento_id { get; set; }
        public string rementente { get; set; }
        public string destinatario { get; set; }
        public DateTime data_hora { get; set; }
        public string mensagem { get; set; }
    }
}
