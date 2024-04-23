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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }
        clsListaDoble ListaDoble = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int codigo))
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = codigo;
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                ListaDoble.Agregar(ObjNodo);

                ListaDoble.Recorrer(dgvDoble);
                ListaDoble.Recorrer(lstDoble);
                ListaDoble.Recorrer(cbDoble);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else
            {
                MessageBox.Show("El codigo ingresado no es valido");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            btnEliminar.Enabled = false;
            if (cbDoble.SelectedIndex != -1)
            {
                if (ListaDoble.Primero != null)
                {
                    Int32 x = Convert.ToInt32(cbDoble.Text);
                    ListaDoble.Eliminar(x);
                    ListaDoble.Recorrer(dgvDoble);
                    ListaDoble.Recorrer(lstDoble);
                    ListaDoble.Recorrer(cbDoble);
                    ListaDoble.Recorrer();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar el codigo");
            }
        }

        private void cbDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoble.SelectedIndex == -1)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.Recorrer(dgvDoble);
            ListaDoble.Recorrer(lstDoble);
            ListaDoble.Recorrer(cbDoble);
            ListaDoble.Recorrer();
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.RecorrerDes(dgvDoble);
            ListaDoble.RecorrerDes(lstDoble);
            ListaDoble.RecorrerDes(cbDoble);
            ListaDoble.RecorrerDes();
        }
    }
}
