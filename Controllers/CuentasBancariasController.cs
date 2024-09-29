using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2024_PC2.Models;
using _2024_PC2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc; // Para IActionResult y Controller

namespace _2024_PC2.Controllers
{
    public class CuentasBancariasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CuentasBancariasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para listar todas las cuentas bancarias
        public async Task<IActionResult> Listar()
        {
            var cuentasBancarias = await _context.CuentasBancarias.ToListAsync();
            return View(cuentasBancarias);
        }

        // GET: Mostrar el formulario de registro
        public IActionResult Registro()
        {
            return View();
        }

        // POST: Guardar la nueva cuenta bancaria en la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registro(CuentaBancaria cuentaBancaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuentaBancaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Listar));
            }
            return View(cuentaBancaria);
        }
    }
}