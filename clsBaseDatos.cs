using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Autor";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Autor");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Autor"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
        public void Listar(DataGridView grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "ResultadoConsulta");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["ResultadoConsulta"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
    }
}
