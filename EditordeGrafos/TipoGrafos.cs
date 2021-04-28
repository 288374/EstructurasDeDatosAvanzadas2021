using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditordeGrafos
{
    public partial class TipoGrafos : Form
    {

        public TipoGrafos()
        {
          InitializeComponent();
            dataGrid();
            
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          



            
        }

        private void dataGrid()
        {

            dataGridView1.Size = new Size(800, 400);
           
            

            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
           

            dataGridView1.Rows[0].Cells[0].Value = "Grafo simple";
            dataGridView1.Rows[1].Cells[0].Value = "Multigrafo";
            dataGridView1.Rows[2].Cells[0].Value = "Seudo Grafo:";
            dataGridView1.Rows[3].Cells[0].Value = "Grafo Dirigido";
            dataGridView1.Rows[4].Cells[0].Value = "Multigrafo Dirigido";
            dataGridView1.Rows[5].Cells[0].Value = "Grafo Actual";


            dataGridView1.Rows[0].Cells[1].Value = "X";
            dataGridView1.Rows[0].Cells[2].Value = "X";
            dataGridView1.Rows[0].Cells[3].Value = "X";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           


            dataGridView1.Rows[1].Cells[1].Value = "x";
            dataGridView1.Rows[1].Cells[2].Value = "✔";
            dataGridView1.Rows[1].Cells[3].Value = "x";

            dataGridView1.Rows[2].Cells[1].Value = "✔";
            dataGridView1.Rows[2].Cells[2].Value = "✔";
            dataGridView1.Rows[2].Cells[3].Value = "x";


            dataGridView1.Rows[3].Cells[1].Value = "✔";
            dataGridView1.Rows[3].Cells[2].Value = "x";
            dataGridView1.Rows[3].Cells[3].Value = "✔";

            dataGridView1.Rows[4].Cells[1].Value = "✔";
            dataGridView1.Rows[4].Cells[2].Value = "✔";
            dataGridView1.Rows[4].Cells[3].Value = "✔";




            //Celdas para poner valores. 
            dataGridView1.Rows[5].Cells[1].Value = "";
            dataGridView1.Rows[5].Cells[2].Value = "";
            dataGridView1.Rows[5].Cells[3].Value = "";





        }

       
        //TextBox para el tipo de Grafo
        private void TipodeGrafo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TipoGrafos_Load(object sender, EventArgs e)
        {

        }
    }
}
