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
    public partial class Euler : Form
    {
        int resultado = 0;
        NodeP N = new NodeP();
        public List<Edge> marca = new List<Edge>();

        public Euler(Graph graph )
        {
            InitializeComponent();
                Euler1(graph);
        }

        public void Euler1(Graph graph)
        {
            int cont = -1;
            int ContadorImpar = 0;
            foreach (NodeP c in graph)
            {
                resultado = 100;
                resultado = c.Degree % 2;
                if (resultado == 0)
                {
                    cont++;
                } else
                {
                    ContadorImpar++;
                }

            }
           



            if (cont == graph.Count)
            {
                foreach (NodeP N in graph)
                {
                    foreach (Edge ar in graph.edgesList)
                    {


                    }
                }

            }
            else if (ContadorImpar == 2 && cont == graph.Count - 2)
            {

            }
            else {
                //No es camino ni circuito 
            }


        }

     /*   public void CaminoEuler(Graph graph)
        {
            //el valor de n será el del primer vértice de la primera arista impar.
            do
            {
                foreach (NodeP c in graph)
                {
                    resultado = 100;
                    resultado = c.Degree % 2;
                    if (resultado != 0)
                    {
                        N = c;
                    }
                }

            } while (N == null);



        }***********/

        public void Conexa(Graph graph)
        {


        }

     /*   public void CircuitoEuler(Graph graph)
        {
            NodeP Aux = new NodeP();
            foreach (Edge ar in marca) {
                ar.Visited = false;
            }

            /*  marca.Clear();
            marca.Add(graph[0]);
            marca[0].Visited = true;
            marca.Clear();
            Aux = graph[0];

            foreach (NodeP n in graph) {
                foreach (Edge ar in graph.edgesList)
                {
                    while (graph.edgesList.Count > -1)
                    {
                        if (n.Name == ar.Source.Name)
                        {
                            if (ar.Visited == false)
                            {
                                ar.Visited = true;
                                marca.Add(ar);
                            }

                        }
                    }


                }
               



                
            }*/


        //}

    }
}

