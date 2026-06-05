public class TabelaPrecoController : Controller
{
    private readonly AppDbContext _context;

    public TabelaPrecoController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.TabelasPreco.ToList());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(TabelaPreco tabela)
    {
        _context.TabelasPreco.Add(tabela);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}