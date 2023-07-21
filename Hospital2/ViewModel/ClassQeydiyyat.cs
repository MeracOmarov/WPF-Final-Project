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
using HOSBITAL.Commands;
using HOSBITAL.Views;
using Hospital.Pasient;
using System.IO;
using System.Text.Json;

namespace HOSBITAL.ViewModel
{
    public class ClassQeydiyyat : INotifyPropertyChanged
    {
        public RealCommand? QeydiyyatCommand { get; set; }
        public RealCommand? male { get; set; }
        public RealCommand? female { get; set; }


        private string? _Name;

        public string Name
        {
            get { return _Name!; }
            set
            {
                if (value.Length < 3 || !Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.nameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.nameTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
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
                    Qeydiyyat.qeydiyyat_pasient!.surnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.surnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _Surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }
        private string? _fathersName;

        public string fathersName
        {
            get { return _fathersName!; }
            set
            {
                if (value.Length < 3 || !Regex.Match(value!, @"\b[A-Z][a-z]+\b").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.fathersnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.fathersnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _fathersName = value;
                OnPropertyChanged(nameof(fathersName));
            }
        }

        private string? _birthday;
        public string birthday
        {
            get { return _birthday!; }
            set
            {

                if (!Regex.Match(value!, @"^(0[1-9]|[1-2][0-9]|3[0-1])/(0[1-9]|1[0-2])/\d{4}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.birthdayTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.birthdayTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _birthday = value;
                OnPropertyChanged(nameof(seriyaID));
            }
        }

        private string? _seriyaID;
        public string seriyaID
        {
            get { return _seriyaID!; }
            set
            {

                if (!Regex.Match(value!, @"^[A-Z]{2}\d{7}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.seriyaIdTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.seriyaIdTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _seriyaID = value;
                OnPropertyChanged(nameof(seriyaID));
            }
        }
        bool check = false;
        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; OnPropertyChanged(nameof(Gender)); }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string? _Number;
        public string Number
        {
            get { return _Number!; }
            set
            {
                if (Regex.Match(value!, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{2}[-\\s\\.]?[0-9]{2}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.numberTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.numberTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                _Number = value;
                OnPropertyChanged(nameof(Number));
            }
        }
        private string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set
            {
                if (!Regex.Match(value!, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").Success)
                {
                    Qeydiyyat.qeydiyyat_pasient!.mailTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);

                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.mailTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _Mail = value;
                OnPropertyChanged(nameof(Mail));
            }
        }


        private string? _Password;
        public string Password
        {
            get { return _Password!; }
            set
            {

                if (value.Length < 6)
                {
                    Qeydiyyat.qeydiyyat_pasient!.passwordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.passwordTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string? _againPassword;
        public string againPassword
        {
            get { return _againPassword!; }
            set
            {
                if (value != Password)
                {
                    Qeydiyyat.qeydiyyat_pasient!.againpasswordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Qeydiyyat.qeydiyyat_pasient!.againpasswordTxtBox.BorderBrush = new SolidColorBrush(Colors.Green);
                }
                _againPassword = value;
                OnPropertyChanged(nameof(againPassword));
            }
        }

        private void QeydiyyatdanKec(object? sender)
        {
            if (string.IsNullOrEmpty(_Name))
            {
                Qeydiyyat.qeydiyyat_pasient!.nameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(_Surname))
            {
                Qeydiyyat.qeydiyyat_pasient!.surnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(_fathersName))
            {
                Qeydiyyat.qeydiyyat_pasient!.fathersnameTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(_birthday))
            {
                Qeydiyyat.qeydiyyat_pasient!.birthdayTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(_seriyaID))
            {
                Qeydiyyat.qeydiyyat_pasient!.seriyaIdTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (Gender != null)
            {
                check = true;
                Qeydiyyat.qeydiyyat_pasient.maleradiobtn.ClearValue(Border.BorderBrushProperty);
                Qeydiyyat.qeydiyyat_pasient.femaleradiobtn.ClearValue(Border.BorderBrushProperty);
            }
           
            if (string.IsNullOrEmpty(_Number))
            {
                Qeydiyyat.qeydiyyat_pasient!.numberTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(_Mail))
            {
                Qeydiyyat.qeydiyyat_pasient!.mailTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(_Password))
            {
                Qeydiyyat.qeydiyyat_pasient!.passwordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (string.IsNullOrEmpty(_againPassword))
            {
                Qeydiyyat.qeydiyyat_pasient!.againpasswordTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }


            var greenBrush = new SolidColorBrush(Colors.Green);

            TextBox[] textBoxes = {
    Qeydiyyat.qeydiyyat_pasient.nameTxtBox,
    Qeydiyyat.qeydiyyat_pasient.surnameTxtBox,
    Qeydiyyat.qeydiyyat_pasient.fathersnameTxtBox,
    Qeydiyyat.qeydiyyat_pasient.seriyaIdTxtBox,
    Qeydiyyat.qeydiyyat_pasient.numberTxtBox,
    Qeydiyyat.qeydiyyat_pasient.mailTxtBox,
    Qeydiyyat.qeydiyyat_pasient.passwordTxtBox,
    Qeydiyyat.qeydiyyat_pasient.againpasswordTxtBox
};

            bool allTextboxesValid = true;

            foreach (var textBox in textBoxes)
            {
                if (textBox.BorderBrush is not SolidColorBrush brush || brush.Color != greenBrush.Color)
                {
                    allTextboxesValid = false;
                    break;
                }
            }

            if (allTextboxesValid)
            {
                    PasientlerDB.Add_data_toBasa(_Name, _Surname, _fathersName, _birthday, _seriyaID, _Gender, _Number, _Mail, _Password);

                Girish.girish!.MainFrame.Content = new Login();
            }



        }
        private void Male(object? sender)
        {
            Gender = "kisi";
        }
        private void Female(object? sender)
        {
            Gender = "qadin";
        }

        public static void WriteData<T>(T? list, string filename)
        {
            JsonSerializerOptions op = new();
            op.WriteIndented = true;
            File.WriteAllText(filename + ".json", JsonSerializer.Serialize(list, op));
        }

        public static T? ReadData<T>(string filename) where T : new()
        {
            T? readData = new T();

            JsonSerializerOptions op = new JsonSerializerOptions();
            op.WriteIndented = true;
            using FileStream fs = new FileStream(filename + ".json", FileMode.OpenOrCreate);
            if (fs.Length != 0) readData = JsonSerializer.Deserialize<T>(fs, op);

            return readData;
        }
        public ClassQeydiyyat()
        {
            QeydiyyatCommand = new(QeydiyyatdanKec);
            male = new(Male);
            female = new(Female);
        }


    }
}
