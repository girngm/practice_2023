using reader;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.ViewModels
{
    public class MakersViewModel
    {
        public ObservableCollection<Maker> SHVNList { get; set; } = new ObservableCollection<Maker>();
        public MakersViewModel()
        {
            
        }
    }
}
