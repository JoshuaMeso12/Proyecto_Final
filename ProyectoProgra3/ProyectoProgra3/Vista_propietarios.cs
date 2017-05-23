using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Vista_propietarios
    {
        private int nit;
        private int nombre;
        private int email;
        private int codigo;

        public int Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public int Nombre
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

        public int Email
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

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }
    }
}
