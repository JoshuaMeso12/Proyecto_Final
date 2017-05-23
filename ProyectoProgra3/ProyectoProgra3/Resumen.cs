using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Resumen
    {
        private string nombre;
        private string zonas;
        private int no_propiedades;
        private int no_propietarios;

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

        public string Zonas
        {
            get
            {
                return zonas;
            }

            set
            {
                zonas = value;
            }
        }

        public int No_propiedades
        {
            get
            {
                return no_propiedades;
            }

            set
            {
                no_propiedades = value;
            }
        }

        public int No_propietarios
        {
            get
            {
                return no_propietarios;
            }

            set
            {
                no_propietarios = value;
            }
        }
    }
}
