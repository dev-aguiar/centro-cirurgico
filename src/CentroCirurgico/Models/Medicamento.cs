namespace CentroCirurgico.Models;

public class Medicamento
{
    public required int Id { get; set; }
    public required string Nome { get; set; }
    public required decimal DoseMgPadrao { get; set; }
    public required ViaAdministracao Via { get; set; }
    public required int QuantidadeEstoque { get; set; }
}