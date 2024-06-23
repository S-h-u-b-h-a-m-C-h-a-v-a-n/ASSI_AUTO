using Microsoft.AspNetCore.Mvc;
using VendorApp.Data;
using VendorApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AUTOMACTIC_INFOTECH_ASSIGMENT.Models;

public class MaterialController : Controller
{
    private readonly ApplicationDbContext _context;

    public MaterialController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: MaterialController/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: MaterialController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ID,Code,Short_Text,Long_Text,Unit,Reorder_Level,Min_Order_Quantity,IsActive")] Material Material)



    {
        if (ModelState.IsValid)
        {
            _context.Add(Material);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(Material);
    }

    // GET: Vendors/Index
    public async Task<IActionResult> Index()
    {
        return View(await _context.Material.ToListAsync());
    }
}
