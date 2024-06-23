using Microsoft.AspNetCore.Mvc;
using VendorApp.Data;
using VendorApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class VendorsController : Controller
{
    private readonly ApplicationDbContext _context;

    public VendorsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Vendors/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Vendors/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ID,Code,Name,Address_Line_1,Address_Line_2,Contact_Email,Contact_No,Valid_Till_Date,IsActive")] Vendor vendor)
    {
        if (ModelState.IsValid)
        {
            _context.Add(vendor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(vendor);
    }

    // GET: Vendors/Index
    public async Task<IActionResult> Index()
    {
        return View(await _context.Vendors.ToListAsync());
    }
}
