using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    internal class Credito : Cuenta
    {
        private decimal MontoCredi;

        public Credito(decimal saldo, decimal transaccion) : base(saldo)
        {
            this.MontoCredi = transaccion;
        }

        

        public override decimal GetNuevoSaldo()
        {
            base.Saldo = Saldo + MontoCredi;
            return Saldo;
        }

        public virtual decimal AgregarCredito(decimal operacion)
        {
            base.Saldo = base.Saldo - operacion;

            return base.Saldo;
        }
    }
}
