using Hospital.Pasient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.Models
{
    public class XesteMuracieti : INotifyPropertyChanged
    {
        private string _analizNovu;
        private string _gun;
        private string _saat;

        public Pasients? pasients { get; set; } = PasientlerDB.CurrentPasient;
        public string analizNovu
        {
            get { return _analizNovu; }
            set
            {
                if (_analizNovu != value)
                {
                    _analizNovu = value;
                    OnPropertyChanged(nameof(analizNovu));
                }
            }
        }

        public string gun
        {
            get { return _gun; }
            set
            {
                if (_gun != value)
                {
                    _gun = value;
                    OnPropertyChanged(nameof(gun));
                }
            }
        }

        public string saat
        {
            get { return _saat; }
            set
            {
                if (_saat != value)
                {
                    _saat = value;
                    OnPropertyChanged(nameof(saat));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
