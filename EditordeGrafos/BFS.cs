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
    public partial class BFS : Form
    {


        private string search;

        private string dff;

        public string Search
        {
            get { return search; }
            set { search = value; }
        }


        public string Dff
        {
            get { return dff; }
            set { dff = value; }
        }



        public BFS()
        {


            InitializeComponent();
        }

        private void BFS_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.dff;
            textBox2.Text = this.search;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
