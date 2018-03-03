using System;
using System.Collections.Generic;
using Examen_patrones.Interfaces;

namespace Examen_patrones
{
    public abstract class Bank
    {
        
        List<Observable> obs;
        public Format format { get; set; }
        public Protocol protocol { get; set; }
        public String Para { get; set; }
        public String De { get; set; }
        public double amount { get; set; }


        public Bank()
        {
            this.obs = new List<Observable>();
        }
        public void add(Observable observer)
        {
            this.obs.Add(observer);
        }
        public void remove(Observable observer)
        {
            this.obs.Remove(observer);
        }

        abstract public void CrearTransaccion(String de, String para, double amount);

        public void notificar(Object obj)
        {
            foreach (Observable observer in obs)
            {
                observer.actualiza(this, obj);
            }
        } 

    }
}
