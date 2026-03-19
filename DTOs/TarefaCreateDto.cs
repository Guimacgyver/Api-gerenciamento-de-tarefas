namespace TarefasApi.DTOs;

public class TarefaCreateDto
{
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public bool Concluida { get; set; }
}