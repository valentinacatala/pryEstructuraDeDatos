using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDeDatos
{
    internal class clsArbolBinario
    {
        //Creo el campo inicial edl arbol. Lo llamamos raiz
        private clsNodo PrimerNodo;

        //Creo la unica propiedad que necesito
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo aux = Raiz;

                while (aux != null)
                {
                    NodoPadre = aux;
                    if (Nvo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierdo;
                    }
                    else
                    {
                        aux = aux.Derecho;
                    }
                }

                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderAsc(Grilla, Raiz);
        }
        public void InOrderAsc(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrderAsc(Grilla, R.Izquierdo);
            }

            Grilla.Rows.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrderAsc(Grilla, R.Derecho);
            }
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrderAsc(Lista, Raiz);
        }
        public void InOrderAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrderAsc(Lst, R.Izquierdo);
            }

            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrderAsc(Lst, R.Derecho);
            }
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        public void PreOrden(clsNodo R, TreeNode NodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            NodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo,NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenGrilla(Grilla, Raiz);
        }
        public void PreOrdenGrilla(DataGridView Grilla, clsNodo R)
        {
            Grilla.Rows.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrdenGrilla(Grilla, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(Grilla, R.Derecho);
            }
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenGrilla(Grilla, Raiz);
        }
        public void PostOrdenGrilla(DataGridView Grilla, clsNodo R)
        {
            
            if (R.Izquierdo != null)
            {
                PreOrdenGrilla(Grilla, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(Grilla, R.Derecho);
            }
            Grilla.Rows.Add(R.Codigo);
        }


    }
}
