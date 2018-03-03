using System;
using Examen_patrones.Interfaces;

namespace Examen_patrones.Modules
{
    public class BankUserB : Observable
    {
        public String CuentaBank { get; set; }

        public BankUserB(String BankAcc)
        {
            this.CuentaBank = BankAcc;
        }

        public void actualiza(Bank observable, object objs)
        {
            Console.WriteLine("BankUserB recibio: " + objs.ToString());
        }
    }
}
