using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDeDatos
{
    class clsCola
    {
         //Campos de las clases
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades de la clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        //Metodos de la clase
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero==null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
            }
            Ultimo = Nuevo;
        }
    }
}
