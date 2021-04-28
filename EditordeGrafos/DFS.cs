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


    public partial class DFS : Form
    {

        private string dff;
        
        public  string Dff {
            get { return dff; }
            set { dff = value; }
        }

        public DFS()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DFS_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.dff;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
