using Microsoft.AspNetCore.Mvc;

public class EstacionamentoController : Controller
{
    private readonly AppDbContext _context;
    private readonly EstacionamentoService _service;

    public EstacionamentoController(AppDbContext context, EstacionamentoService service)
    {
        _context = context;
        _service = service;
    }

    public IActionResult Index()
    {
        var veiculos = _context.Veiculos.ToList();
        return View(veiculos);
    }

    public IActionResult Entrada()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Entrada(Veiculo veiculo)
    {
        veiculo.DataEntrada = DateTime.Now;

        _context.Veiculos.Add(veiculo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Saida(string placa)
    {
        var veiculo = _context.Veiculos.FirstOrDefault(v => v.Placa == placa && v.DataSaida == null);
        if (veiculo == null)
        {
            return NotFound();
        }
        
        var tabela = _context.TabelasPreco.FirstOrDefault(t => veiculo.DataEntrada >= t.VigenciaInicio && veiculo.DataEntrada <= t.VigenciaFim);

        veiculo.DataSaida = DateTime.Now;
        veiculo.ValorPago = _service.CalcularValor(veiculo.DataEntrada, veiculo.DataSaida.Value, tabela);

        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}