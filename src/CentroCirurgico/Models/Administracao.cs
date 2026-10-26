namespace CentroCirurgico.Models;

public record Administracao
{
    public required int Id { get; init; }
    public required int MedicamentoId { get; init; }
    public required int AnestesistaId { get; init; }
    public required string DoseMg { get; init; }
    public required DateTime DataHora { get; init; }
};