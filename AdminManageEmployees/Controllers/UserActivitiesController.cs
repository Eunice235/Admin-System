using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminManageEmployees.Models;

namespace AdminManageEmployees.Controllers
{
    public class UserActivitiesController : Controller
    {
        private readonly AdminDbContext _context;

        public UserActivitiesController(AdminDbContext context)
        {
            _context = context;
        }

        // GET: UserActivities
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserActivities.ToListAsync());
        }

        // GET: UserActivities/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userActivity = await _context.UserActivities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userActivity == null)
            {
                return NotFound();
            }

            return View(userActivity);
        }

        // GET: UserActivities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserActivities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreateeOn,ModifiedBy,ModifiedOn")] UserActivity userActivity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userActivity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userActivity);
        }

        // GET: UserActivities/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userActivity = await _context.UserActivities.FindAsync(id);
            if (userActivity == null)
            {
                return NotFound();
            }
            return View(userActivity);
        }

        // POST: UserActivities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,CreateeOn,ModifiedBy,ModifiedOn")] UserActivity userActivity)
        {
            if (id != userActivity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userActivity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserActivityExists(userActivity.Id))
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
            return View(userActivity);
        }

        // GET: UserActivities/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userActivity = await _context.UserActivities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userActivity == null)
            {
                return NotFound();
            }

            return View(userActivity);
        }

        // POST: UserActivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userActivity = await _context.UserActivities.FindAsync(id);
            if (userActivity != null)
            {
                _context.UserActivities.Remove(userActivity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserActivityExists(string id)
        {
            return _context.UserActivities.Any(e => e.Id == id);
        }
    }
}
