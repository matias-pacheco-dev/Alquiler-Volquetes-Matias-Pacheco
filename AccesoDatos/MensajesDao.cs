using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MensajesDao : BaseDao<Mensaje>
    {
        public void InsertarMensaje(Mensaje mensaje)
        {
            string query = "INSERT INTO mensajes (ID_usuario, Remitente, Mensaje) VALUES (@id_usuario, @Remitente, @Mensaje)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Mensaje", mensaje.Contenido },
                { "@id_usuario", mensaje.Destinatario },
                { "@Remitente", mensaje.Remitente }
            };

            ExecuteScalar(query, parameters);
        }

        public Queue<Mensaje> ObtenerMensajesPorIdUsuario(int IdUsuario)
        {
            Queue<Mensaje> mensajes = new Queue<Mensaje>();
            string query = "SELECT Remitente, ID_usuario, Mensaje FROM mensajes WHERE ID_usuario = @id_usuario";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_usuario", IdUsuario }
            };

            ExecuteReader(query, parameters, reader =>
            {
                while (reader.Read())
                {
                    Mensaje mensaje = new Mensaje(
                        Convert.ToString(reader["Remitente"]),
                        Convert.ToInt32(reader["ID_usuario"]),
                        Convert.ToString(reader["Mensaje"])
                    );

                    mensajes.Enqueue(mensaje);
                }
            });

            return mensajes;
        }

    }
}


