using GestaoComercial.Api.Models;
using GestaoComercial.Api.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoService _service;
    public ProdutosController(IProdutoService service) => _service = service;

    // GET: api/produtos
    [HttpGet]
    public IActionResult GetAll()
    {
        var produtos = _service.GetAll();
        return Ok(produtos);
    }

    // GET: api/produtos/{id}
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var produto = _service.GetById(id);
        if (produto == null)
            return NotFound();
        return Ok(produto);
    }

    // POST: api/produtos
    [HttpPost]
    public IActionResult Create([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var criado = _service.Create(produto);
        return CreatedAtAction(nameof(GetById), new { id = criado.Id }, criado);
    }

    // PUT: api/produtos/{id}
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Produto produto)
    {
        var atualizado = _service.Update(id, produto);

        if (atualizado == null)
            return NotFound();

        return Ok(atualizado);
    }

    // DELETE: api/produtos/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deletado = _service.Delete(id);

        if (!deletado)
            return NotFound();

        return NoContent();
    }
}