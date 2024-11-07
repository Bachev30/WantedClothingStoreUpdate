using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WantedClothingStore.Models;

namespace WantedClothingStore.Controllers
{
    public class WomenProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WomenProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WomenProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.WomenProducts.ToListAsync());
        }

        // GET: WomenProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var womenProduct = await _context.WomenProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (womenProduct == null)
            {
                return NotFound();
            }

            return View(womenProduct);
        }

        // GET: WomenProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WomenProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DressType,FabricType,Color,IsPopularItem,CategorySpecificAttribute,Id,Name,Price,Size,Description,ImageUrl")] WomenProduct womenProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(womenProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(womenProduct);
        }

        // GET: WomenProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var womenProduct = await _context.WomenProducts.FindAsync(id);
            if (womenProduct == null)
            {
                return NotFound();
            }
            return View(womenProduct);
        }

        // POST: WomenProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DressType,FabricType,Color,IsPopularItem,CategorySpecificAttribute,Id,Name,Price,Size,Description,ImageUrl")] WomenProduct womenProduct)
        {
            if (id != womenProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(womenProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WomenProductExists(womenProduct.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(womenProduct);
        }

        // GET: WomenProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var womenProduct = await _context.WomenProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (womenProduct == null)
            {
                return NotFound();
            }

            return View(womenProduct);
        }

        // POST: WomenProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var womenProduct = await _context.WomenProducts.FindAsync(id);
            if (womenProduct != null)
            {
                _context.WomenProducts.Remove(womenProduct);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WomenProductExists(int id)
        {
            return _context.WomenProducts.Any(e => e.Id == id);
        }
    }
}
