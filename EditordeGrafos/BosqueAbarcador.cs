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
    public partial class BosqueAbarcador : Form
    {
        private string nodosVisitados;


        public string NodosVistados
            {
               get { return nodosVisitados; }
               set { nodosVisitados = value; }
            
            }



   

        public BosqueAbarcador()
        {
            InitializeComponent();
        }

        private void BosqueAbarcador_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.NodosVistados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
