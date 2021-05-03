using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebServiceApi.Models;
using WebServiceApi.Models.Bd;

namespace WebServiceApi.Controllers
{
    public class ScheduleFormsController : Controller
    {
        private readonly ContextSql _context;

        public ScheduleFormsController(ContextSql context)
        {
            _context = context;
        }

        // GET: ScheduleForms
        public async Task<IActionResult> Index()
        {
            return View(await _context.SchedulesForms.ToListAsync());
        }

        // GET: ScheduleForms/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleForm = await _context.SchedulesForms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduleForm == null)
            {
                return NotFound();
            }

            return View(scheduleForm);
        }

        // GET: ScheduleForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScheduleForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,Address,Phone,Service,Date,Enabled,Id")] ScheduleForm scheduleForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduleForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheduleForm);
        }

        // GET: ScheduleForms/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleForm = await _context.SchedulesForms.FindAsync(id);
            if (scheduleForm == null)
            {
                return NotFound();
            }
            return View(scheduleForm);
        }

        // POST: ScheduleForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize("Bearer")]
        public async Task<IActionResult> Edit(long id, [Bind("FirstName,LastName,Email,Address,Phone,Service,Date,Enabled,Id")] ScheduleForm scheduleForm)
        {
            if (id != scheduleForm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduleForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleFormExists(scheduleForm.Id))
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
            return View(scheduleForm);
        }

        // GET: ScheduleForms/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduleForm = await _context.SchedulesForms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheduleForm == null)
            {
                return NotFound();
            }

            return View(scheduleForm);
        }

        // POST: ScheduleForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize("Bearer")]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var scheduleForm = await _context.SchedulesForms.FindAsync(id);
            _context.SchedulesForms.Remove(scheduleForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleFormExists(long id)
        {
            return _context.SchedulesForms.Any(e => e.Id == id);
        }
    }
}
