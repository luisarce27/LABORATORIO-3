using System;

namespace Ejercicio01
{
    class Program
    //Console.WriteLine("Digite el monto que desea");
    //string x = Console.ReadLine();
    //decimal Monto = decimal.Parse(x);
    //Console.WriteLine("Digite el Tipo de cuenta: 1: Credito    2: Debito");
    //string y = Console.ReadLine();
    //int select = int.Parse(y);

    //if (select == 1)
    //{

    //}
    //else
    //{

    //}
    {
        static void Main(string[] args)
        {
            Cuenta CuentaDebito = new Debito(15000, 0);

            Cuenta CuentaCredito = new Credito(0, 0);

                   int selec = 0;

            while (selec != 3)
            {
                Console.WriteLine("Seleccione proceso: 1 - Crédito  2 - Débito  3 - Salir ");

                string cadselec;

                cadselec = Console.ReadLine();

                selec = Convert.ToInt32(cadselec);

                if (selec == 1)
                {
                    
                    Console.WriteLine("Digite monto de venta aplicable a tarjeta de crédito ");

                    decimal monto;

                    monto = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine();

                    CuentaCredito.Saldo = CuentaCredito.Saldo + monto;

                    Console.WriteLine("");

                    Console.WriteLine("Saldo en Cuenta de Crédito es: " + CuentaCredito.Saldo);

                    Console.WriteLine("");

                }
                else if (selec == 2)
                {
                    
                    Console.WriteLine("Digite monto de venta aplicable a tarjeta de débito ");

                    decimal monto;

                    monto = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine();

                    if (monto > CuentaDebito.Saldo)
                    {
                        Console.WriteLine("");

                        Console.WriteLine("Transacción no se puede realizar, saldo insuficiente");

                        Console.WriteLine("");
                    }
                    else
                    {
                        CuentaDebito.Saldo = CuentaDebito.Saldo - monto;

                        Console.WriteLine("");

                        Console.WriteLine("Saldo en la Cuenta de Débito es: " + CuentaDebito.Saldo);

                        Console.WriteLine("");
                    }
                }
                
                else
                {
                    Console.WriteLine("");

                    Console.WriteLine("Opción digitada no es válida ");

                    Console.WriteLine("");
                }
            }
        }
    }
}
