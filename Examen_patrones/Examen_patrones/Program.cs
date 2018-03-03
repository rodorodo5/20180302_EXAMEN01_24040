using System;
using Examen_patrones.Modules;

namespace Examen_patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to rodo's bank transfer system");
            BankUserA BankUserA = new BankUserA("RODOLFO");
            BankUserB BankUserB = new BankUserB("PEPE");
            BankA bankA = new BankA();
            bankA.add(BankUserA);
            bankA.CrearTransaccion(BankUserB.CuentaBank, BankUserA.CuentaBank, 100000);
            Console.ReadLine();
        }
    }
}
