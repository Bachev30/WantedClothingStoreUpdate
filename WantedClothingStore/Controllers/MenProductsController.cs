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
    public class MenProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MenProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.MenProducts.ToListAsync());
        }

        // GET: MenProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menProduct = await _context.MenProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menProduct == null)
            {
                return NotFound();
            }

            return View(menProduct);
        }

        // GET: MenProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MenProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClothingType,Material,FitType,Color,IsPopularItem,CategorySpecificAttribute,Id,Name,Price,Size,Description,ImageUrl")] MenProduct menProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(menProduct);
        }

        // GET: MenProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menProduct = await _context.MenProducts.FindAsync(id);
            if (menProduct == null)
            {
                return NotFound();
            }
            return View(menProduct);
        }

        // POST: MenProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClothingType,Material,FitType,Color,IsPopularItem,CategorySpecificAttribute,Id,Name,Price,Size,Description,ImageUrl")] MenProduct menProduct)
        {
            if (id != menProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenProductExists(menProduct.Id))
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
            return View(menProduct);
        }

        // GET: MenProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menProduct = await _context.MenProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menProduct == null)
            {
                return NotFound();
            }

            return View(menProduct);
        }

        // POST: MenProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menProduct = await _context.MenProducts.FindAsync(id);
            if (menProduct != null)
            {
                _context.MenProducts.Remove(menProduct);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenProductExists(int id)
        {
            return _context.MenProducts.Any(e => e.Id == id);
        }
    }
}
