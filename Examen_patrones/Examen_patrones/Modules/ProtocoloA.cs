using System;
using Examen_patrones.Interfaces;

namespace Examen_patrones.Modules
{
    public class ProtocoloA : Protocol
    {
        public ProtocoloA()
        {
        }

        public string InformacionTransaccion()
        {
            return "FTP";
        }
    }
}
