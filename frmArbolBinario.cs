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
        //https://forms.gle/4ucTDDjEfpdCFKqi8

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
                ArbolBinario.Recorrer(cbArbol);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";

                rbInOrdenAsc.Checked = true;
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
            ArbolBinario.RecorrerInOrden();
           
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            ArbolBinario.RecorrerPreOrden(dgvArbol);
            ArbolBinario.Recorrer(treeBinario);
            ArbolBinario.Recorrer(cbArbol);
            ArbolBinario.RecorrerPreOrden();
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            ArbolBinario.RecorrerPostOrden(dgvArbol);
            ArbolBinario.Recorrer(cbArbol);
            ArbolBinario.RecorrerPostOrden();
        }

        private void rbInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
            ArbolBinario.RecorrerDesc(dgvArbol);
            ArbolBinario.RecorrerDesc(cbArbol);
            ArbolBinario.RecorrerDesc();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            if (cbArbol.SelectedIndex != -1)
            {
                Int32 codigoAEliminar = Convert.ToInt32(cbArbol.Text);
                ArbolBinario.Eliminar(codigoAEliminar);

                ArbolBinario.Recorrer(dgvArbol);
                ArbolBinario.Recorrer(treeBinario);
                ArbolBinario.Recorrer(cbArbol);
            }
            else
            {
                MessageBox.Show("Seleccionar un codigo para eliminar");
            }
            
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            ArbolBinario.Equilibrar();
            ArbolBinario.Recorrer(dgvArbol);
            ArbolBinario.Recorrer(treeBinario);
            ArbolBinario.Recorrer(cbArbol);
        }

        private void cbArbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArbol.SelectedIndex == cbArbol.Items.Count - 1)
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
