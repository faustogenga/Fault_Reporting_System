using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.src
{
    internal class Persona
    {
        protected const string EMPLEADO = "Empleado";
        protected const string CLIENTE = "Cliente";
        protected int cedula { get; set; }
        protected string nombre { get; set; }
        protected string telefono { get; set; }
        protected string correoElectronico { get; set; }
        protected string rol { get; set; }

        public Persona() { }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nCedula: " + cedula + "\nTelefono: " + telefono + "\nEmail: " + correoElectronico;
        }
        public void consultarTiquetes(string tiquete)
        {
            Console.WriteLine("El tiquete es: " + tiquete);
        }
    }
}
