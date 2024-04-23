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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }
        clsArbolBinario ArbolBinario = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int codigo))
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = codigo;
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                ArbolBinario.Agregar(ObjNodo);

                ArbolBinario.Recorrer(dgvArbol);
                ArbolBinario.Recorrer(treeBinario);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else
            {
                MessageBox.Show("El codigo ingresado no es valido");
            }
            
        }

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {

            ArbolBinario.Recorrer(dgvArbol);
            ArbolBinario.Recorrer(cbArbol);
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            ArbolBinario.RecorrerPreOrden(dgvArbol);
            ArbolBinario.Recorrer(treeBinario);
            ArbolBinario.Recorrer(cbArbol);
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            ArbolBinario.RecorrerPostOrden(dgvArbol);
            ArbolBinario.Recorrer(cbArbol);
        }
    }
}
