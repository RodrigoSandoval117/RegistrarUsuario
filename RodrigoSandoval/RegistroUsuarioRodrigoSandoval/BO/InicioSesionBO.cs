using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroUsuarioRodrigoSandoval.BO
{
    public class InicioSesionBO
    {
        string usuario, contrasena;
        bool activo;

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }
    }
}