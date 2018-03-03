using System;
namespace Examen_patrones.Modules
{
    public class BankC : Bank
    {
        String notificacion = "";

        public BankC() : base() {
            this.format = new FormatC();
            this.protocol = new ProtocoloC();

            this.notificacion = "Transaccion: " + amount + " Utiliza  " +
                this.format.fortmatType() + " " + this.protocol.InformacionTransaccion();
        }


        public override void CrearTransaccion(string de, string para, double amount)
        {
            notificacion = "Cuenta origen: " + de + ", Cuenta Destino: " + para + "";
            notificar(notificacion);
        }
    }
}
