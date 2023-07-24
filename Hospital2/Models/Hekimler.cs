using HOSBITAL.ViewModel;
using Hospital.Pasient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.Models
{
    public class Hekimler : INotifyPropertyChanged
    {

        public List<ClassMuracietler>? muracietler { get; set; }
        public List<PasientlerDB> ?pasients { get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
