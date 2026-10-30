namespace CentroCirurgico.Models;

public class Anestesista
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Crm { get; init; }
    public required string Especialidade { get; set; }
}