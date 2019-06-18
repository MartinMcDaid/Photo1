using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Photo1.Models;

namespace Photo1.Controllers
{
    public class CarouselsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICarouselRepository _carouselRepository;

        public CarouselsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Carousels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carousels.ToListAsync());
        }

        // GET: Carousels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousels
                .FirstOrDefaultAsync(m => m.CarouselId == id);
            if (carousel == null)
            {
                return NotFound();
            }

            return View(carousel);
        }

        // GET: Carousels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carousels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarouselId,CarouselUrl")] Carousel carousel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carousel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carousel);
        }

        // GET: Carousels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousels.FindAsync(id);
            if (carousel == null)
            {
                return NotFound();
            }
            return View(carousel);
        }

        // POST: Carousels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarouselId,CarouselUrl")] Carousel carousel)
        {
            if (id != carousel.CarouselId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carousel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarouselExists(carousel.CarouselId))
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
            return View(carousel);
        }

        // GET: Carousels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousels
                .FirstOrDefaultAsync(m => m.CarouselId == id);
            if (carousel == null)
            {
                return NotFound();
            }

            return View(carousel);
        }

        // POST: Carousels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carousel = await _context.Carousels.FindAsync(id);
            _context.Carousels.Remove(carousel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarouselExists(int id)
        {
            return _context.Carousels.Any(e => e.CarouselId == id);
        }
    }
}
