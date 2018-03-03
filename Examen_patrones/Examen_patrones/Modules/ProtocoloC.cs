using System;
using Examen_patrones.Interfaces;

namespace Examen_patrones.Modules
{
    public class ProtocoloC : Protocol
    {
        public ProtocoloC()
        {
        }
        public string InformacionTransaccion()
        {
            return "SSH";
        }
    }
}
