using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{

    class Cliente
    {

        protected String Nombre;
        protected String Apellido;
        protected Sueldo Suel;
        protected String Tipo;


        public Cliente() { }

        public Cliente(String nombre, String apellido, Sueldo sueldo)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Suel = sueldo;
        }

        public void setNombre(String nombre)
        {

            this.Nombre = nombre;
        }

        public String getNombre()
        {

            return this.Nombre;
        }

        public void setApellido(String apellido)
        {

            this.Apellido = apellido;
        }

        public String getApellido()
        {

            return this.Apellido;
        }

        public void setSueldo(Sueldo sueldo)
        {

            this.Suel = sueldo;
        }

        public Sueldo getSueldo()
        {

            return this.Suel;
        }
        public  void setTipo(String tipo)
        {

            this.Tipo = tipo;

        }

        public  String getTipo()
        {
            return this.Tipo;
        }

        public virtual void mostrar()
        {
            
        }

    }
}