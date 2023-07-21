using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows;
using System.ComponentModel;
using HOSBITAL.Pages;
using System.Windows.Controls;
using System.Windows.Media;
using Hospital.Pages;

namespace HOSBITAL.ViewModel
{
    public class ClassQeydiyyat:INotifyPropertyChanged
    {
		private string ?_Name;
        
		public string Name
		{
			get { return _Name!; }
			set {
                if (string.IsNullOrEmpty(value) || value.Length<3 || !Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.txtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.txtBox.BorderBrush=new SolidColorBrush(Colors.Green);
                }
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
		}
        private string? _Surname;
        public string Surname
        {
            get { return _Surname!; }
            set
            {
                if (!Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success)
                { 
                    MessageBox.Show("Invalid Surname!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                _Surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }



		public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int myVar;
        public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}


	}
}
