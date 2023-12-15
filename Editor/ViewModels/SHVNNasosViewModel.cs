using reader;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.ViewModels
{
    public class SHVNNasosViewModel
    {
        public ObservableCollection<SHVN_Nasos> SHVNList { get; set; } = new ObservableCollection<SHVN_Nasos>();
        public SHVNNasosViewModel()
        {
            
        }
    }
}
