using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploClase3
{
    internal class Cuenta
    {
        int monto;
        public enum tipoExtraccion {
            cajeroHumano = 1,
            cajeroAutomatico = 2
        };
        public enum tipoCuenta
        {
            corrientePesos = 1,
            corrienteDolares = 2,
            cajaAhorro = 3
        };

        public void insercion(int monto)
        {

        }
        public void extraccion(int monto, tipoExtraccion tipo)
        {

        }
    }
}
