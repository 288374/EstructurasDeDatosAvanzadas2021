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
    public partial class Dijkstra : Form
    {
        public List<List<int>> ListAdyacencia = new List<List<int>>();
        public List<int> auxiliar = new List<int>();
        public List<NodeP> marca = new List<NodeP>();
        public string name;
        public string bff_prueba;

        public List<NodeP> s = new List<NodeP>();
        public List<NodeP> V = new List<NodeP>();
        public NodeP W = new NodeP();
        public string cadena = "";
        public int index = 0;
        public int index2 = 0;
        private Graph graph;

        public Graph Graph
        {
            get { return graph;  }
            set { graph = value; }

        }


        public int Index
        {
            get { return index; }
            set
            {
                index = value;

            }
        }
        public int Index2
        {
            get { return index2; }
            set
            {
                index2 = value;

            }
        }

        public Dijkstra(Graph graphm, int i1, int i2)
        {
            InitializeComponent();
            this.index = i1;
            this.index2 = i2;
            this.graph = graphm;
            dijkstra(graph);
            CreaGrid(graph);
            BucarCamino(graph);
            NodoOrigenDestino(graph);
            
        }

      

        public void dijkstra(Graph graph)
        {
            textBox1.Text = " ";
            NodosRecorridos.Clear();
            label5.Text = " ";
            Vector.Text = " ";

            for (int j = 0; j < graph.Count; j++)
            {
                auxiliar = new List<int>();
                for (int i = 0; i < graph.Count; i++)
                {
                    auxiliar.Add(0);
                }
                ListAdyacencia.Add(auxiliar);
            }

            if (graph.Count > 0)  //Para saber si la lista tiene elementos 
            {
                foreach (Edge Ar in graph.edgesList)
                {

                    //posiciones            // i                               //j
                    ListAdyacencia[ConvierteLetra(Ar.Source.Name)][ConvierteLetra(Ar.Destiny.Name)] = Ar.Weight;   // Arista dirigida 
                }
            }

            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = 0; j < graph.Count; j++)
                {

                    if (ListAdyacencia[i][j] == 0)
                    {
                        ListAdyacencia[i][j] = 10000;

                    }
                  //  if (i == j)
                   // {

                     //   ListAdyacencia[i][j] = 0;
                    //}
                    



                }
                

            }
          
            for (int i = 0; i < graph.Count; i++)
            {
                V.Add(graph[i]);

            }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CreaGrid(Graph graph)
        {


            List<string> cadena = new List<string>();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Size = new Size(800, 400);

            //dataGridView1.Columns.Add(" ", " ");
            foreach (NodeP c in graph)
            {
                dataGridView1.Columns.Add(c.Name, c.Name);

            }


            for (int N = 0; N < graph.Count; N++)
            {
                dataGridView1.Rows.Add();

                cadena.Add(graph[N].Name);


                cadena = new List<string>();

                for (int M = 0; M < graph.Count; M++)
                {
                    cadena.Add(ListAdyacencia[N][M].ToString());
                    dataGridView1.Rows[N].Cells[M].Value = ListAdyacencia[N][M].ToString();
                    dataGridView1.Rows[N].HeaderCell.Value = graph[N].Name + "     ";
                    dataGridView1.RowHeadersWidth = 50;
                }

            }


        }

        public void BucarCamino(Graph graph)
        {

            int x = 100000;
            int j = 0;
            int[] distancia; // Declaración del array
            NodosRecorridos.Clear();

            distancia = new int[graph.Count]; // Instanciación del array
            s.Add(graph[index]);
            V.RemoveAt(index);
            if (index == 0)
            {

                for (int i = 0; i < graph.Count; i++)
                {
                    distancia[i] = ListAdyacencia[0][i];
                }
            }
            else  if(index != 0)
            {

                for (int i = 0; i < index; i++)
                {
                    distancia[i] = ListAdyacencia[index][i];

                }

                for (int i = index; i < graph.Count; i++)
                {
                    distancia[i] = ListAdyacencia[index][i];
                }
            }

            for (int i =0; i < graph.Count; i++)
            {
                if (distancia[i] < x)
                {
                    x = distancia[i];
                    j = i;
                }
            }
            s.Add(graph[j]);



            //   V.RemoveAt(j);
            for (int k = 0; k < graph.Count; k++)
            {

                foreach (Edge ar in graph.edgesList)
                {

                    if (graph[k].Name == ar.Source.Name)
                    {

                        distancia[ConvierteLetra(ar.Destiny.Name)] = Minimo(distancia[ConvierteLetra(ar.Destiny.Name)], distancia[ConvierteLetra(ar.Source.Name)] + ListAdyacencia[ConvierteLetra(ar.Source.Name)][(ConvierteLetra(ar.Destiny.Name))]);

                    }
                }
                NodosRecorridos.Text +=  "->" + graph[k].Name + "->";
            }
            for (int i = 0; i< graph.Count; i++)

            {
                Vector.Text += distancia[i].ToString() + "->" ;
            }


            textBox1.Text += distancia[index2].ToString();
        
            label5.Text = graph[index].Name + "->" + graph[index2].Name;
          

        }




        public int Minimo(int entero1, int entero2)
        {

            if (entero1 < entero2)
            {

                return entero1;
            }
            else 
            {
                return entero2;
            }

        }

        public void NodoOrigenDestino(Graph graph)
        {
            for (int i = 0; i < graph.Count; i++)
            {
                comboBox1.Items.Add(graph[i].Name);
                comboBox2.Items.Add(graph[i].Name);
            }
        }

        private void NodosRecorridos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vector_TextChanged(object sender, EventArgs e)
        {
                }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;

          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            index2 = comboBox2.SelectedIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dijktra_Click(object sender, EventArgs e)
        {
            dijkstra(graph );
           CreaGrid(graph);
            BucarCamino(graph);
        }
    }
}

 

