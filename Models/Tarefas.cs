
namespace TarefasApi.Models;

public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; }
    public bool Concluida { get; set; }
}
