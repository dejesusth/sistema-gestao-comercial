using GestaoComercial.Api.Models;
using GestaoComercial.Api.Services;
using GestaoComercial.Api.Repositories;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repo;

    public ProdutoService(IProdutoRepository repo) => _repo = repo;

    public IEnumerable<Produto> GetAll() => _repo.GetAll();

    public Produto? GetById(int id) => _repo.GetById(id);

    public Produto Create(Produto produto)
    {
        if (produto.Preco < 0)
            throw new ArgumentException("Preço inválido.");
            _repo.Add(produto);
            return produto;
    }

    public Produto? Update(int id, Produto produto)
    {
        if (_repo.GetById(id) == null) return null;
        produto.Id = id;
        _repo.Update(produto);
        return produto;
    }

    public bool Delete(int id)
    {
        var produto = _repo.GetById(id);
        if (produto == null)
        {
            return false;
        }
        _repo.Delete(id);
        return true;
    }
}