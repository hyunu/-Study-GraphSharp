using QuickGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SubClassRedesgnGraph
{
    public class XGraph : BidirectionalGraph<XVertex, XEdge>
    {
        public XGraph() { }

        public XGraph(bool allowParallelEdges) 
            : base(allowParallelEdges) { }

        public XGraph(bool allowParallelEdges, int vertexCapacity)
            : base(allowParallelEdges, vertexCapacity) { }
    }
}
