using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Proyecto_Final.src
{
    internal class Cliente : Persona
    {
        protected string password;

        public Cliente()
        {

        }
        public Cliente(string nombre, string correoElectronico, int cedula, string password)
        {
            this.correoElectronico = correoElectronico;
            this.nombre = nombre;
            this.rol = CLIENTE;
            this.password = password;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nCedula: " + cedula + "\nTelefono: " + telefono + "\nEmail: " + correoElectronico + "Rol: " + rol;
        }
    }
}
