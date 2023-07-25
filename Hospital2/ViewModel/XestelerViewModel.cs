using Hospital.Pasient;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.ViewModel
{
    public class XestelerViewModel
    {
        public ObservableCollection<Pasients>? pasients { get; set; } = PasientlerDB.pasients;   
    }
}
