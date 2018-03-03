using System;
namespace Examen_patrones.Modules
{
    public class BankA :  Bank
    {
        String notificacion = "";

        public BankA() : base() {
            this.format = new FormatA();
            this.protocol = new ProtocoloA();

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
