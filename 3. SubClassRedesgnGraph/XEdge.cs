using QuickGraph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SubClassRedesgnGraph
{
    public class XEdge : Edge<XVertex>, INotifyPropertyChanged
    {
        public string LineName;

        public XEdge(string linename, XVertex source, XVertex target):base(source, target)
        {
            LineName = linename;
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion
    }
}
