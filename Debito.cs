using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    internal class Debito : Cuenta
    {
        private decimal MontoDebito
            ;

        public Debito(decimal saldo, decimal transaccion) : base(saldo)
        {
            this.MontoDebito = transaccion;
        }

        public override decimal GetNuevoSaldo()
        {
            base.Saldo = Saldo - MontoDebito;
            return Saldo;
        }
    }
}
