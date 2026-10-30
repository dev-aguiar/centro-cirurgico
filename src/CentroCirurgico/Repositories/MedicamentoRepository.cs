using CentroCirurgico.Models;

namespace CentroCirurgico.Repositories;

public class MedicamentoRepository : IMedicamentoRepository
{
    private readonly List<Medicamento> _medicamentos = new();
    
    public void Adicionar(Medicamento medicamento)
    {
        _medicamentos.Add(medicamento);
    }

    public IReadOnlyList<Medicamento> ListarTodos()
    {
        return _medicamentos;
    }

    public Medicamento? BuscarPorId(int id)
    {
        return _medicamentos.FirstOrDefault(m => m.Id == id);
    }
}