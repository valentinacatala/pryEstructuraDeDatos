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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmBaseDatosOperaciones_Load(object sender, EventArgs e)
        {
            
            
        }

        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT Titulo " +
                "FROM Libro " +
                "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnProyeccionmultiatributo_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT IdLibro, Titulo " +
                "FROM Libro " +
                "ORDER BY 1 DESC"; ;
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * " +
                "FROM Libro, Idioma " +
                "WHERE Libro.IdIdioma = Idioma.IdIdioma";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * " +
                "FROM Libro " +
                "WHERE IdAutor = 3";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro " +
                "WHERE IdAutor=2 " +
                "OR IdAutor=3";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSeleccionConvulsion_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * " +
                "FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) " +
                "as T2 WHERE T2.IdAutor > 10";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro WHERE IdAutor = 2 " +
                "UNION " +
                "SELECT* FROM Libro WHERE IdAutor = 5 " +
                "UNION " +
                "SELECT* FROM Libro WHERE IdAutor = 3";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                "IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                "NOT IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma< 5)";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }
    }
}
