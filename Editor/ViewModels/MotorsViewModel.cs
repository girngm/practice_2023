using reader;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.ViewModels
{
    public class MotorsViewModel
    {
        public ObservableCollection<Motor> MotorList { get; set; } = new ObservableCollection<Motor>();
        public string Test { get; set; } = "Принц Михаил Валентинович";
        public MotorsViewModel()
        {
            
        }
    }
}
