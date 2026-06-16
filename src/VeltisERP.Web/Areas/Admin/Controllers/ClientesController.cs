using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeltisERP.Infrastructure.Data;

namespace VeltisERP.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class ClientesController : Controller
{
    private readonly AppDbContext _context;

    public ClientesController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var clientes = await _context.Clientes
            .Include(x => x.Empresa)
            .ToListAsync();

        return View(clientes);
    }
}