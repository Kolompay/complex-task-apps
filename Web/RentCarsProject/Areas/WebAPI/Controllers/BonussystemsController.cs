using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarsProject
{
    [Route("Bonussystems")]
    [ApiController]
    [Area("WebAPI")]
    public class BonussystemsController : Controller
    {
        private readonly rentcarsdbContext _context;

        public BonussystemsController(rentcarsdbContext context)
        {
            _context = context;
        }

        // GET: WebAPI/Bonussystems
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bonussystems.ToListAsync());
        }

        // GET: WebAPI/Bonussystems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bonussystem = await _context.Bonussystems
                .FirstOrDefaultAsync(m => m.Idbonussystem == id);
            if (bonussystem == null)
            {
                return NotFound();
            }

            return View(bonussystem);
        }

        // GET: WebAPI/Bonussystems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebAPI/Bonussystems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idbonussystem,Description,Discountpercent")] Bonussystem bonussystem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bonussystem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bonussystem);
        }

        //// GET: WebAPI/Bonussystems/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var bonussystem = await _context.Bonussystems.FindAsync(id);
        //    if (bonussystem == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(bonussystem);
        //}

        //// POST: WebAPI/Bonussystems/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Idbonussystem,Description,Discountpercent")] Bonussystem bonussystem)
        //{
        //    if (id != bonussystem.Idbonussystem)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(bonussystem);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BonussystemExists(bonussystem.Idbonussystem))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(bonussystem);
        //}

        //// GET: WebAPI/Bonussystems/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var bonussystem = await _context.Bonussystems
        //        .FirstOrDefaultAsync(m => m.Idbonussystem == id);
        //    if (bonussystem == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(bonussystem);
        //}

        //// POST: WebAPI/Bonussystems/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var bonussystem = await _context.Bonussystems.FindAsync(id);
        //    _context.Bonussystems.Remove(bonussystem);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BonussystemExists(int id)
        //{
        //    return _context.Bonussystems.Any(e => e.Idbonussystem == id);
        //}
    }
}
