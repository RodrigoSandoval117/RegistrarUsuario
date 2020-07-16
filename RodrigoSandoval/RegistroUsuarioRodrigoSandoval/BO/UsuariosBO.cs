using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroUsuarioRodrigoSandoval.BO
{
    public class UsuariosBO
    {
        int iDUsuario, edad;
        string nombre, email, estado, telefono;
        bool privacidad, activo;
        DateTime fechaCreacion;

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

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int IDUsuario
        {
            get
            {
                return iDUsuario;
            }

            set
            {
                iDUsuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public bool Privacidad
        {
            get
            {
                return privacidad;
            }

            set
            {
                privacidad = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }
    }
}