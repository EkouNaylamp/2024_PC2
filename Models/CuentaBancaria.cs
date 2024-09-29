using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2024_PC2.Models
{
    public class CuentaBancaria
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public string? Email { get; set; }
    }
}