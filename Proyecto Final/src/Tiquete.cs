using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.src
{
    internal class Tiquete
    {
         int id;
         int cedulaUsuario ;
         int cedulaAdmin; 
         string asunto ;
         string descripcion ;
         string estado ;
         string tipo ;
         string severidad;
         DateTime fecha;

        public Tiquete() { }

        // Complete constructor
        public Tiquete(int idticket, int cedulaUsuario, int cedulaAdmin, string asunto, string descripcion, string estado, string tipo, string severidad, DateTime fecha)
        {
            id = idticket;
            this.cedulaUsuario = cedulaUsuario;
            this.cedulaAdmin = cedulaAdmin;
            this.asunto = asunto;
            this.descripcion = descripcion;
            this.estado = estado;
            this.tipo = tipo;
            this.severidad = severidad;
            this.fecha = fecha;
        }
        // Generate 6 digit random number
        public int GenerateRandomNumber()
        {
            Random rnd = new();
            return rnd.Next(100000, 999999);
        }

        //getters and setters
        public int Id { get => id; set => id = value; }
        public int CedulaUsuario { get => cedulaUsuario; set => cedulaUsuario = value; }
        public int CedulaAdmin { get => cedulaAdmin; set => cedulaAdmin = value; }
        public string Asunto { get => asunto; set => asunto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Severidad { get => severidad; set => severidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

    }
}
