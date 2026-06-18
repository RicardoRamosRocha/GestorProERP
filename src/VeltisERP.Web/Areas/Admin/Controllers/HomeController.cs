using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VeltisERP.Infrastructure.Data;

namespace VeltisERP.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.TotalClientes = _context.Clientes.Count();
        ViewBag.TotalEmpresas = _context.Empresas.Count();

        return View();
    }
}