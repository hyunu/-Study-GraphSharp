using GraphSharp.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _3.SubClassRedesgnGraph
{
    public class XGraphLayout : GraphLayout<XVertex, XEdge, XGraph> { }

    /// <summary>
    /// XGraphControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class XGraphControl : UserControl, INotifyPropertyChanged
    {
        public XGraph Graph { get; set; }

        public XGraphControl()
        {
            Graph = new XGraph();

            //add the vertices to the graph
            XVertex[] vertices = new XVertex[5];
            for (int i = 0; i < 5; i++)
            {
                vertices[i] = new XVertex();
                vertices[i].Name1 = i.ToString();
                Graph.AddVertex(vertices[i]);
            }

            //add some edges to the graph
            Graph.AddEdge(new XEdge("line", vertices[0], vertices[1]));
            Graph.AddEdge(new XEdge("line", vertices[1], vertices[2]));
            Graph.AddEdge(new XEdge("line", vertices[2], vertices[3]));
            Graph.AddEdge(new XEdge("line", vertices[3], vertices[1]));
            Graph.AddEdge(new XEdge("line", vertices[1], vertices[4]));
            //
            //
            InitializeComponent();
            //
            layout.Graph = Graph;
            
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion
    }
}
