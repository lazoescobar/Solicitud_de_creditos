using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Validacion
    {

        public bool EsNombre ( String nombre ){

            bool resultado = false;

            //EXPRESION PUEDE SOMETERSE A NUEVOS REQUIRIMIENTOS
            Regex expresion = new Regex( "^[A-Z|a-z]*$" );

            if ( expresion.IsMatch ( nombre ) == true ) {

                resultado = true;
            }

            return resultado;
        }

        public bool EsApelllido ( String apellido ) {

            bool resultado = false;

            //EXPRESION PUEDE SOMETERSE A NUEVOS REQUIRIMIENTOS
            Regex expresion = new Regex( "^[A-Z|a-z]*$" );

            if ( expresion.IsMatch ( apellido ) == true ) {

                resultado = true;
            }

            return resultado;
        }

        public bool EsMontoDeDinero ( String sueldo ){

            bool resultado = false;

            Regex expresion = new Regex( "^[1-9][0-9]*$" );

            if ( expresion.IsMatch ( sueldo ) == true ) {

                resultado = true;
            }

            return resultado;
        }

        public bool EsOpcion ( String opcion ) {

            bool resultado = false;

            Regex expresion = new Regex( "^[1-2]$" );

            if (expresion.IsMatch( opcion ) == true)
            {

                resultado = true;
            }

            return resultado;
        }

        public bool EsCuotas( String cuotas ) {

            bool resultado = false;

            Regex expresion = new Regex( "^[0-9]*$");

            if ( expresion.IsMatch( cuotas ) == true)
            {

                resultado = true;
            }

            return resultado;
        }

    }
}
