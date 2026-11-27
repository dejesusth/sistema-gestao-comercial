using GestaoComercial.Api.Models;

namespace GestaoComercial.Api.Services;

public interface IProdutoService
{
    IEnumerable<Produto> GetAll();
    Produto? GetById(int id);
    Produto Create(Produto produto);
    Produto? Update(int id, Produto produto);
    bool Delete(int id);
}