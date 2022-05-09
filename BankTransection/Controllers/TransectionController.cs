﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankTransection.Models;

namespace BankTransection.Controllers
{
    public class TransectionController : Controller
    {
        private readonly TransectionDbContext _context;

        public TransectionController(TransectionDbContext context)
        {
            _context = context;
        }

        // GET: Transection
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transections.ToListAsync());
        }

        // GET: Transection/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transection = await _context.Transections
                .FirstOrDefaultAsync(m => m.TranstionID == id);
            if (transection == null)
            {
                return NotFound();
            }

            return View(transection);
        }

        // GET: Transection/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transection/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TranstionID,AccountNumber,BenicifiaryName,BankName,SwiftCode,Amount")] Transection transection)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transection);
        }

        // GET: Transection/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transection = await _context.Transections.FindAsync(id);
            if (transection == null)
            {
                return NotFound();
            }
            return View(transection);
        }

        // POST: Transection/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TranstionID,AccountNumber,BenicifiaryName,BankName,SwiftCode,Amount")] Transection transection)
        {
            if (id != transection.TranstionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransectionExists(transection.TranstionID))
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
            return View(transection);
        }

        // GET: Transection/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transection = await _context.Transections
                .FirstOrDefaultAsync(m => m.TranstionID == id);
            if (transection == null)
            {
                return NotFound();
            }

            return View(transection);
        }

        // POST: Transection/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var transection = await _context.Transections.FindAsync(id);
            _context.Transections.Remove(transection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransectionExists(string id)
        {
            return _context.Transections.Any(e => e.TranstionID == id);
        }
    }
}
