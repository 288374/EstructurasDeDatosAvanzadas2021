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
    public partial class GradoGrafos : Form
    {
        public List<List<int>> ListAdyacencia = new List<List<int>>();
        public List<int> auxiliar = new List<int>();
        public string name;
        public GradoGrafos(Graph graph)
        {

            InitializeComponent();
            creaGrid(graph);


        }

        private void GradoGrafos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void creaGrid(Graph graph)
        {

            List<string> cadena = new List<string>();
            dataGridView1.Rows.Clear();

            dataGridView1.Size = new Size(800, 400);
            int total = 0;


            foreach (NodeP c in graph)
            {

                dataGridView1.Rows.Add(c.Name, c.Degree.ToString());
                total += c.Degree;

            }

            dataGridView1.Rows.Add("Total", total.ToString() );


         
        }
            public int ConvierteLetra(string letra)
            {
                int Num = 0;


                if (letra == "A")
                {
                    Num = 0;
                }
                else if (letra == "B")
                {
                    Num = 1;
                }
                else if (letra == "C")
                {
                    Num = 2;
                }
                else if (letra == "D")
                {
                    Num = 3;
                }
                else if (letra == "E")
                {
                    Num = 4;
                }
                else if (letra == "F")
                {
                    Num = 5;
                }
                else if (letra == "G")
                {
                    Num = 6;
                }
                else if (letra == "H")
                {
                    Num = 7;
                }
                else if (letra == "I")
                {
                    Num = 8;
                }
                else if (letra == "J")
                {
                    Num = 9;
                }
                else if (letra == "K")
                {
                    Num = 10;
                }
                else if (letra == "L")
                {
                    Num = 11;
                }
                else if (letra == "M")
                {
                    Num = 12;
                }
                else if (letra == "N")
                {
                    Num = 13;
                }
                else if (letra == "O")
                {
                    Num = 14;
                }
                else if (letra == "P")
                {
                    Num = 15;
                }
                else if (letra == "Q")
                {
                    Num = 16;
                }
                else if (letra == "R")
                {
                    Num = 17;
                }
                else if (letra == "S")
                {
                    Num = 18;
                }
                else if (letra == "T")
                {
                    Num = 19;
                }
                else if (letra == "U")
                {
                    Num = 20;
                }
                else if (letra == "V")
                {
                    Num = 21;
                }
                else if (letra == "W")
                {
                    Num = 22;
                }
                else if (letra == "X")
                {
                    Num = 23;
                }
                else if (letra == "Y")
                {
                    Num = 24;
                }
                else if (letra == "Z")
                {
                    Num = 25;
                }
                return Num;

            }

        }


    }

