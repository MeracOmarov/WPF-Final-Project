using Hospital.Pasient;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSBITAL.ViewModel
{
    public class ClassMuracietler
    {
        public PasientlerDB pasientlerDBs { get; set; } = new();
        public static Hekimler hekimler { get; set; } = new();

        public ClassMuracietler()
        {
            hekimler.xesteMuracieti=ClassQeydiyyat.ReadData<ObservableCollection<XesteMuracieti>>("muracietler")!;
        }
    }
}
