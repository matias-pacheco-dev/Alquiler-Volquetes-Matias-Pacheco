using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface ISerializable<T>
    {
        bool Serializar(T datos);

        T Deserializar();



    }
}
