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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void frmBaseDatosRepasoOperaciones_Load(object sender, EventArgs e)
        {

        }
        

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            string varSQL = "SELECT * FROM Libro ";
            switch (cbOperaciones.SelectedIndex)
            {
                case 0:
                    lblOperacion.Text=cbOperaciones.Text + ": " +
                        "Paises que no tienen libros";
                    varSQL = "";
                break;
                    
            }
        }
    }
}
