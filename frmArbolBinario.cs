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

                if (rbInOrden.Checked)
                {
                    ArbolBinario.Recorrer(dgvArbol); 
                }
                else if (rbPreOrden.Checked)
                {
                    ArbolBinario.RecorrerPreOrden(dgvArbol);
                    ArbolBinario.Recorrer(treeBinario);
                }
                else if (rbPostOrden.Checked)
                {
                    ArbolBinario.RecorrerPostOrden(dgvArbol);
                }
            }
            else
            {
                MessageBox.Show("El codigo ingresado no es valido");
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
