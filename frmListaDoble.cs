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
            

            if (rbAscendente.Checked)
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                ListaDoble.Agregar(ObjNodo);
                ListaDoble.RecorrerAsc(dgvDoble);
                ListaDoble.RecorrerAsc(lstDoble);
                ListaDoble.RecorrerAsc(cbSimple);
                ListaDoble.RecorrerAsc();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            if (rbAscendente.Checked)
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                ListaDoble.Agregar(ObjNodo);
                ListaDoble.RecorrerDes(dgvDoble);
                ListaDoble.RecorrerDes(lstDoble);
                ListaDoble.RecorrerDes(cbSimple);
                ListaDoble.RecorrerDes();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            
        }
    }
}
