using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Cuota_propietarios
    {
        private string nit;
        private string nombre;
        private string porcentaje;
        private string importes;

        public string Nit
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

        public string Porcentaje
        {
            get
            {
                return porcentaje;
            }

            set
            {
                porcentaje = value;
            }
        }

        public string Importes
        {
            get
            {
                return importes;
            }

            set
            {
                importes = value;
            }
        }
    }
}
