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
                        "Libros escritos por Virginia o por Alfred Doblin";
                    varSQL = "SELECT * FROM Libro WHERE IdAutor = 3 " +
                    "UNION " +
                    "SELECT* FROM Libro WHERE IdAutor = 5 ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 1:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros de Reino Unido o de Argentina";
                    varSQL = "SELECT * FROM Libro WHERE IdPais = 24 " +
                    "UNION " +
                    "SELECT* FROM Libro WHERE IdPais = 1 ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;
                    
                case 2:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros en Español o Inglés";
                    varSQL = "SELECT * FROM Libro WHERE IdIdioma = 6 " +
                    "UNION " +
                    "SELECT* FROM Libro WHERE IdIdioma = 1 ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 3:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros que no sean en Inglés, Ruso o Alemán";
                    varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                    "NOT IN " +
                    "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma <= 3) ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 4:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros que no hayan sido escritos por Virginia o Carlos";
                    varSQL = "SELECT * FROM Libro WHERE IdAutor " +
                    "NOT IN " +
                    "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdAutor <= 3)";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 5:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros en Inglés, Ruso, Alemán o Persa";
                    varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                    "IN " +
                    "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;
                    
                case 6:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros de Portugal o Islandia";
                    varSQL = "SELECT * FROM Libro WHERE IdPais " +
                    "IN " +
                    "(SELECT DISTINCT IdPais FROM Libro WHERE IdPais = 22 OR IdPais= 25 )";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;
                    
                case 7:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros escritos por Gabriel García Márquez";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE IdAutor = 8";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 8:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros que tienen una cantidad de 7 unidades";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE Cantidad = 7";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 9:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros de Rusia escritos por Virginia ";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE IdAutor=3 " +
                    "AND IdPais=3";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 10:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros de Reino Unido o que hayan sido escritos por Saadi ";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE IdAutor=6 " +
                    "OR IdPais=1";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 11:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros escritos por Carlos, Virginia o Toni Morrison en Inglés o Ruso";
                    varSQL = "SELECT * FROM " +
                        "(SELECT * FROM Libro AS T1 WHERE T1.IdIdioma < 3) " +
                        "AS T2 WHERE T2.IdAutor < 5";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 12:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Titulos de los libros en orden descendente alfabético";
                    varSQL = "SELECT Titulo " +
                    "FROM Libro " +
                    "ORDER BY 1 DESC";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 13:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Nombres de autores en orden ascendente alfabético";
                    varSQL = "SELECT Nombre " +
                    "FROM Autor " +
                    "ORDER BY 1";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 14:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Nombres de paises en orden ascendente alfabético";
                    varSQL = "SELECT Nombre " +
                    "FROM Pais " +
                    "ORDER BY 1";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 15:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Nombres de idiomas en orden descendente alfabético";
                    varSQL = "SELECT Nombre " +
                    "FROM Idioma " +
                    "ORDER BY 1 DESC";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;
                case 16:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Titulo del libro con la cantidad de unidades dispobibles";
                    varSQL = "SELECT Titulo, Cantidad " +
                    "FROM Libro ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;
                case 17:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Titulos del libro con su precio";
                    varSQL = "SELECT Titulo, Precio " +
                    "FROM Libro ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;
                case 18:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros con los idiomas en los que fueron escritos";
                    varSQL = "SELECT * " +
                    "FROM Libro, Idioma " +
                    "WHERE Libro.IdIdioma = Idioma.IdIdioma ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;

                case 19:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros con los nombres de sus respectivos autores";
                    varSQL = "SELECT * " +
                    "FROM Libro, Autor " +
                    "WHERE Libro.IdAutor = Autor.IdAutor ";
                    objBaseDatos.Listar(dgvOperaciones, varSQL);
                    break;
                
                    
            }
        }
    }
}
