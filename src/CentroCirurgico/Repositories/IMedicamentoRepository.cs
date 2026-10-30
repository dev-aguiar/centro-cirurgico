namespace CentroCirurgico.Repositories;

using CentroCirurgico.Models;

public interface IMedicamentoRepository
{
    void Adicionar(Medicamento medicamento);
    IReadOnlyList<Medicamento> ListarTodos();
    Medicamento? BuscarPorId(int id);
}