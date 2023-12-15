using reader;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.ViewModels
{
    public class ECNViewModel
    {
        public ObservableCollection<ECN> ECNList { get; set; } = new ObservableCollection<ECN>();
        public ECNViewModel()
        {
            
        }
    }
}
