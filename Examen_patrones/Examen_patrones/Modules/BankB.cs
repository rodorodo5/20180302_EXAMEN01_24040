using System;
namespace Examen_patrones.Modules
{
    public class BankB : Bank
    {
        String notificacion = "";

        public BankB() : base() {
            this.format = new FormatB();
            this.protocol = new ProtocoloB();

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
