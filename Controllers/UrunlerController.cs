using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UrunTakipProjesi.Models;

namespace UrunTakipProjesi.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly UrunTakipContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UrunlerController(UrunTakipContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _hostEnvironment = hostEnvironment ?? throw new ArgumentNullException(nameof(hostEnvironment));
        }

        // GET: Urunler
        public async Task<IActionResult> Index()
        {
            var urunler = _context.Urunler?.Include(u => u.Kategori);
            if (urunler == null) return Problem("Entity set 'UrunTakipContext.Urunler' is null.");
            return View(await urunler.ToListAsync());
        }

        // GET: Urunler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Urunler == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunler
                .Include(u => u.Kategori)
                .FirstOrDefaultAsync(m => m.UrunId == id);
            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // GET: Urunler/Create
        public IActionResult Create()
        {
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "KategoriId", "KategoriAd");
            return View();
        }

        // POST: Urunler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UrunId,UrunAd,UrunFiyat,UrunAdet,UrunPhoto,ImageFile,KategoriId")] Urun urun)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (urun.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(urun.ImageFile.FileName);
                        string extension = Path.GetExtension(urun.ImageFile.FileName);
                        fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        urun.UrunPhoto = "/Contents/" + fileName;
                        string path = Path.Combine(wwwRootPath + "/Contents/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await urun.ImageFile.CopyToAsync(fileStream);
                        }
                    }

                    _context.Add(urun);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "KategoriId", "KategoriAd", urun.KategoriId);
            return View(urun);
        }

        // GET: Urunler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Urunler == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunler.FindAsync(id);
            if (urun == null)
            {
                return NotFound();
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "KategoriId", "KategoriAd", urun.KategoriId);
            return View(urun);
        }

        // POST: Urunler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UrunId,UrunAd,UrunFiyat,UrunAdet,UrunPhoto,ImageFile,KategoriId")] Urun urun)
        {
            if (id != urun.UrunId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (urun.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(urun.ImageFile.FileName);
                        string extension = Path.GetExtension(urun.ImageFile.FileName);
                        fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        urun.UrunPhoto = "/Contents/" + fileName;
                        string path = Path.Combine(wwwRootPath + "/Contents/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await urun.ImageFile.CopyToAsync(fileStream);
                        }
                    }

                    _context.Update(urun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrunExists(urun.UrunId))
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
            ViewData["KategoriId"] = new SelectList(_context.Kategoriler, "KategoriId", "KategoriAd", urun.KategoriId);
            return View(urun);
        }

        // GET: Urunler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Urunler == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunler
                .Include(u => u.Kategori)
                .FirstOrDefaultAsync(m => m.UrunId == id);
            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // POST: Urunler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Urunler == null)
            {
                return Problem("Entity set 'UrunTakipContext.Urunler' is null.");
            }
            var urun = await _context.Urunler.FindAsync(id);
            if (urun != null)
            {
                _context.Urunler.Remove(urun);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UrunExists(int id)
        {
            return _context.Urunler?.Any(e => e.UrunId == id) ?? false;
        }
    }
}
