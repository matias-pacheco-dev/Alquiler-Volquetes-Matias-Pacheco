using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IMetodoPago
    {
        string ProcesarPago(decimal monto);
        void GenerarFactura(Alquiler alquiler);

    }
}
