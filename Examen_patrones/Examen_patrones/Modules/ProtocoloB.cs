using System;
using Examen_patrones.Interfaces;

namespace Examen_patrones.Modules
{
    public class ProtocoloB : Protocol
    {
        public ProtocoloB()
        {
        }
        public string InformacionTransaccion()
        {
            return "HTTP";
        }
    }
}
