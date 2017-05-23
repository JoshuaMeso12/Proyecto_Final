using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Vista_propiedades
    {
        private string t_propiedad;
        private string codigo;
        private string m_cuadrados;
        private string nombre;
        private string cuotas;
        private string info_ad;

        public string T_propiedad
        {
            get
            {
                return t_propiedad;
            }

            set
            {
                t_propiedad = value;
            }
        }

        public string Codigo
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

        public string Cuadrados
        {
            get
            {
                return m_cuadrados;
            }

            set
            {
                m_cuadrados = value;
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

        public string Cuotas
        {
            get
            {
                return cuotas;
            }

            set
            {
                cuotas = value;
            }
        }

        public string Info_ad
        {
            get
            {
                return info_ad;
            }

            set
            {
                info_ad = value;
            }
        }
    }
}
