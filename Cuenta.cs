using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class Cuenta
    {
        public decimal Saldo { get; set; }

        public Cuenta(decimal saldo)
        {
            this.Saldo = saldo;
        }

        public virtual decimal GetNuevoSaldo()
        {
            return Saldo;
        }
    }
}
