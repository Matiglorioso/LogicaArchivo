using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar 4 espacios de nombre !!
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;



namespace ProgLogicaArchivosBD
{
    class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Cliente";

        public void ListarTodos(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach(DataRow Reg in DS.Tables[Tabla].Rows)
                    {
                        Grilla.Rows.Add(Reg["IdCliente"], Reg["Nombre"], Reg["Deuda"]);

                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }


        }
        public void ListarDeudores(DataGridView Grilla)
        {
            try
            {
                    conexion.ConnectionString = CadenaConexion;
                    conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow Reg in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToDecimal(Reg["Deuda"]) > 0 )
                        {
                            Grilla.Rows.Add(Reg["IdCliente"], Reg["Nombre"], Reg["Deuda"]);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }


        }
        public void Exportar()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                StreamWriter Archivo = new StreamWriter("Datos.csv", false, Encoding.UTF8);
                Archivo.WriteLine("Listado de Clientes");
                Archivo.WriteLine("");
                Archivo.WriteLine("Nombre;Deuda;Limite");
                if (DS.Tables[Tabla].Rows.Count > 0) //si el contador de filas de la tabla del DataSet es mayor a 0
                {
                    foreach (DataRow Reg in DS.Tables[Tabla].Rows) //leer mientras haya filas en el DataSet
                    {
                        Archivo.Write(Reg["Nombre"]);
                        Archivo.Write(";");
                        Archivo.Write(Reg["Deuda"]);
                        Archivo.Write(";");
                        Archivo.WriteLine(Reg["Limite"]);//Dato + salto de linea

                    }
                }
                Archivo.Close();    
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }   
        }
    }
}
