﻿using QuickGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private IBidirectionalGraph<object, IEdge<object>> _graphToVisualize;

        public IBidirectionalGraph<object, IEdge<object>> GraphToVisualize
        {
            get { return _graphToVisualize; }
        }

        public MainWindow()
        {
            CreateGraphToVisualize();

            InitializeComponent();
            graphLayout.Graph = GraphToVisualize;
        }

        private void CreateGraphToVisualize()
        {
            var g = new BidirectionalGraph<object, IEdge<object>>();

            //add the vertices to the graph
            string[] vertices = new string[5];
            for (int i = 0; i < 5; i++)
            {
                vertices[i] = i.ToString();
                g.AddVertex(vertices[i]);
            }

            //add some edges to the graph
            g.AddEdge(new Edge<object>(vertices[0], vertices[1]));
            g.AddEdge(new Edge<object>(vertices[1], vertices[2]));
            g.AddEdge(new Edge<object>(vertices[2], vertices[3]));
            g.AddEdge(new Edge<object>(vertices[3], vertices[1]));
            g.AddEdge(new Edge<object>(vertices[1], vertices[4]));

            _graphToVisualize = g;
        }
    }
}
