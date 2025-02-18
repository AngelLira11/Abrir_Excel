using System.Windows.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;


namespace Abrir_Excel
{
    public partial class Form1 : Form
    {
        string nombre_heder = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogo = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx", Title = "Selecciona un archivo de Excel" };
            if (dialogo.ShowDialog() == DialogResult.OK) CargarExcel(dialogo.FileName);


        }
        //se utilizo la libreria Oledb para abrir archivos en excel la cual permite ver el archivo 
        //en el datagridview talk y cual se mostraria en el archivo de excel 

        //FUENTES: https://learn.microsoft.com/es-es/office/vba/excel/concepts/ole-db-for-olap-properties-used-by-excel
        private void CargarExcel(string ruta)
        {
            string aux = ruta.EndsWith(".xls") ?
           $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={ruta};Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'" :
           $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'";

            try
            {
                using (var conn = new OleDbConnection(aux))
                {
                    conn.Open();
                    string hoja = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0]["TABLE_NAME"].ToString();
                    var adaptador = new OleDbDataAdapter($"SELECT * FROM [{hoja}]", conn);
                    var dt = new DataTable();
                    adaptador.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewEditor.Columns.Clear();
                        dataGridViewEditor.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnColumna_Click(object sender, EventArgs e)
        {
            string name = txtNameColumna.Text;

            if (dataGridViewEditor.Columns.Count == 0)
            {
                //agrega la primera columna si esta vacia la tabla
                dataGridViewEditor.Columns.Add(name, name);
            }
            else
            {
                // agregar nueva columna a la tabla
                int nuevaColumnaIndex = dataGridViewEditor.Columns.Count + 1;

                // poner nombre a la columna
                string nombreColumna = name + nuevaColumnaIndex;
                string encabezadoColumna = name + nuevaColumnaIndex;

                // agregar columna con nombre
                dataGridViewEditor.Columns.Add(nombreColumna, encabezadoColumna);
            }
        }

        private void btnFila_Click(object sender, EventArgs e)
        {

            if (dataGridViewEditor.Columns.Count == 0)
            {
                MessageBox.Show("Debe haber al menos una columna antes de agregar filas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una nueva fila vacía
            DataGridViewRow nuevaFila = new DataGridViewRow();

            // Agregar celdas vacías a la nueva fila
            for (int i = 0; i < dataGridViewEditor.Columns.Count; i++)
            {
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell());
            }

            // Agregar nueva fila a la tabla
            dataGridViewEditor.Rows.Add(nuevaFila);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridViewEditor.Rows.Clear();
            dataGridViewEditor.Columns.Clear();

        }
    }
}
