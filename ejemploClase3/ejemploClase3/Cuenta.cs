using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploClase3
{
    internal class Cuenta
    {
        public int monto;
        public enum tipoExtraccion {
            cajeroHumano = 1,
            cajeroAutomatico = 2
        };
        

        public void insercion(int _monto)
        {
            monto += _monto;
        }
        public void extraccion(int _monto, tipoExtraccion tipo)
        {
            if(tipo == tipoExtraccion.cajeroHumano)
            {
                if (_monto > monto)
                {
                    monto -= _monto;
                }
                else
                {
                    Console.WriteLine("Esta intentando sacar mas dinero del que tiene");
                }
            }
        }
    }

    class CuentaPesos : Cuenta
    {

    }
}
