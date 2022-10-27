using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace ProgLogicaArchivosBD
{
    class clsArchivoTexto
    {
        private String NombreArchivo = "Clientes.csv"; // comma separated values (valores separados por coma)
        private Decimal Deuda = 0;

        public Decimal TotalDeuda
        {
            get { return Deuda; }
        }

        public void GrabarDatos(string cod, string nom, string deu)
        {
            //Abrir en modo de escritura para agregar.
            StreamWriter archivo = new StreamWriter(NombreArchivo, true, Encoding.UTF8);
            //Grabar
            archivo.Write(cod);
            archivo.Write(";");
            archivo.Write(nom);
            archivo.Write(";");
            archivo.WriteLine(deu); //dato más salto de línea (Enter)!!!
            //Cerrar
            archivo.Close();
            archivo.Dispose(); // para liberar memoria
        }

        public void ListarDatos(DataGridView Grilla)
        {
            String DatoLeido = "";
            String[] Vector = new String[3]; //va a tener 3 lugares
            Grilla.Rows.Clear();
            Deuda = 0;
            StreamReader archivo = new StreamReader(NombreArchivo);
            DatoLeido = archivo.ReadLine(); //Leer una fila
            while (DatoLeido != null)
            {
                Vector = DatoLeido.Split(';'); // le asigno lo que tiene la variable DatoLeido (split = partir, corta la cadena donde encuentra ;)
                Grilla.Rows.Add(Vector[0], Vector[1], Vector[2]);
                Deuda = Deuda + Convert.ToDecimal(Vector[2]); // acumula el valor de la deuda que esta en la posicion 2
                DatoLeido = archivo.ReadLine(); //volver a leer una fila (antes del cierre)
            }
            archivo.Close();
            archivo.Dispose(); 
        }

        public void ExportarDatos()
        {
            Int32 cantidad = 0;
            Deuda = 0;
            String[] vector = new String[3];
            String DatoLeido = "";
            StreamWriter reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);
            reporte.WriteLine("Listado de clientes");
            reporte.WriteLine("");
            reporte.WriteLine("Código;Nombre;Deuda");
            StreamReader archivo = new StreamReader(NombreArchivo);
            DatoLeido = archivo.ReadLine();
            while(DatoLeido!=null)
            {
                reporte.WriteLine(DatoLeido);
                vector = DatoLeido.Split(';');
                Deuda = Deuda + Convert.ToDecimal(vector[2]);
                cantidad++;                
                DatoLeido = archivo.ReadLine();
            }
            reporte.WriteLine("");
            reporte.WriteLine("");
            reporte.Write("Cantidad de clientes:;;");
            reporte.WriteLine(cantidad);
            reporte.Write("Total de deuda:;;");
            reporte.WriteLine(Deuda);
            reporte.Write("Promedio de Deuda:;;");
            reporte.WriteLine(Deuda/cantidad);
            reporte.Close();
            reporte.Dispose();
            archivo.Close();
            archivo.Dispose();
        }
        public void Imprimir(PrintPageEventArgs reporte)
        {
            Font Titulo = new Font("Arial", 20);
            Font Subtitulo = new Font("Arial", 12);
            Font Texto = new Font("Arial", 10);
            Int32 Fila = 180;
            Int32 Cantidad = 0;
            Deuda = 0;
            reporte.Graphics.DrawString("Listado de clientes", Titulo, Brushes.DarkRed, 100, 100);
            reporte.Graphics.DrawString("Código", Subtitulo, Brushes.AliceBlue, 200, 150);
            reporte.Graphics.DrawString("Nombre", Subtitulo, Brushes.AliceBlue, 300, 150);
            reporte.Graphics.DrawString("Deuda", Subtitulo, Brushes.AliceBlue, 400, 150);
            String[] Vector = new String[3];
            String DatoLeido = "";
            StreamReader archivo = new StreamReader(NombreArchivo);
            DatoLeido = archivo.ReadLine();
            while(DatoLeido != null)
            {
                Vector = DatoLeido.Split(';');
                DatoLeido = archivo.ReadLine();
                reporte.Graphics.DrawString(Vector[0], Texto, Brushes.Black, 100, Fila);
                reporte.Graphics.DrawString(Vector[1], Texto, Brushes.Black, 200, Fila);
                reporte.Graphics.DrawString(Vector[2], Texto, Brushes.Black, 300, Fila);
                Fila = Fila + 20;
                Cantidad = Cantidad + 1;
                Deuda = Deuda + Convert.ToDecimal(Vector[2]);

            }
            reporte.Graphics.DrawString("Cantidad de clientes: " + Cantidad.ToString(), Texto, Brushes.Black, 100, Fila);
            Fila = Fila + 40;
            reporte.Graphics.DrawString("Deuda clientes: " + Deuda.ToString("0.00"), Texto, Brushes.Black, 100, Fila);
            archivo.Close();
            archivo.Dispose();

        }

    }
}
