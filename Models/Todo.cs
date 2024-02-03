using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorTarefasAutenticacao.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Título da tarefa")]
        [Required(ErrorMessage = "Digite o nome da tarefa")]
        public string TarefaName { get; set; } = string.Empty;

        [DisplayName("Descrição")]
        public string TarefaDescription { get; set; } = string.Empty;

        [DisplayName("Data da Tarefa")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataTarefa { get; set; }

        [DisplayName("Status da tarefa")]
        public string StatusTarefa { get; set; }

        public string User { get; set; }
    }
}
