using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bhuma_Devi_Acharya_Dot_Net_Assignment.Data;
using Bhuma_Devi_Acharya_Dot_Net_Assignment.Models;
using Microsoft.AspNetCore.Authorization;

namespace Bhuma_Devi_Acharya_Dot_Net_Assignment.Controllers
{
    [Authorize]

    public class TeacherLeavesController : Controller
    {
        private readonly Bhuma_Devi_Acharya_Dot_Net_AssignmentContext _context;

        public TeacherLeavesController(Bhuma_Devi_Acharya_Dot_Net_AssignmentContext context)
        {
            _context = context;
        }

        // GET: TeacherLeaves
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeacherLeaves.ToListAsync());
        }

        // GET: TeacherLeaves/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeacherLeaves/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherName,LeaveStartDate,NumberOfDays")] TeacherLeave teacherLeave)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherLeave);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacherLeave);
        }

        // GET: TeacherLeaves/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherLeave = await _context.TeacherLeaves.FindAsync(id);
            if (teacherLeave == null)
            {
                return NotFound();
            }
            return View(teacherLeave);
        }

        // POST: TeacherLeaves/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeacherName,LeaveStartDate,NumberOfDays")] TeacherLeave teacherLeave)
        {
            if (id != teacherLeave.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherLeave);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.TeacherLeaves.Any(e => e.Id == teacherLeave.Id))
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
            return View(teacherLeave);
        }

        // GET: TeacherLeaves/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherLeave = await _context.TeacherLeaves
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacherLeave == null)
            {
                return NotFound();
            }

            return View(teacherLeave);
        }

        // POST: TeacherLeaves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacherLeave = await _context.TeacherLeaves.FindAsync(id);
            _context.TeacherLeaves.Remove(teacherLeave);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
