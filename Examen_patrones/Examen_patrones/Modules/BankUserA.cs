using System;
using Examen_patrones.Interfaces;

namespace Examen_patrones.Modules
{
    public class BankUserA : Observable
    {
        public String CuentaBank { get; set; }

        public BankUserA(String BankAcc)
        {
            this.CuentaBank = BankAcc;
        }

        public void actualiza(Bank observable, object objs)
        {
            Console.WriteLine("BankUserA recibio: " + objs.ToString());
        }
    }
}

