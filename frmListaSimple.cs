using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
        clsListaSimple ListaSimple = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            ListaSimple.Agregar(ObjNodo);
            ListaSimple.Recorrer(dgvSimple);
            ListaSimple.Recorrer(lstSimple);
            ListaSimple.Recorrer(cbSimple);
            ListaSimple.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaSimple.Primero!=null)
            {
                Int32 x = Convert.ToInt32(cbSimple.Text);
                ListaSimple.Eliminar(x);
                ListaSimple.Recorrer(dgvSimple);
                ListaSimple.Recorrer(lstSimple);
                ListaSimple.Recorrer(cbSimple);
                ListaSimple.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
            btnEliminar.Enabled = false;
        }

        private void cbSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSimple.Text=="")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
