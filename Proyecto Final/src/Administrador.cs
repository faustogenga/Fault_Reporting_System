using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.src
{
    internal class Administrador : Persona
    {
        protected string password;

        public Administrador()
        {

        }

        public Administrador(int cedula, string nombre,string correoElectronico, string password)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
            this.password = password;
            this.rol = EMPLEADO;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nCedula: " + cedula + "\nEmail: " + correoElectronico + "Rol: " + rol;
        }
    }
}
