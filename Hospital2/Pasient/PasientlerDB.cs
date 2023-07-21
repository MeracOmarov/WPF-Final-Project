using HOSBITAL.ViewModel;
using Hospital.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Pasient
{
    public class PasientlerDB
    {
        public static List<string> pasient = new List<string>() { "Merac", "2000", "Ibo", "2003" };

        // pasinet databazaya data add ededn funksiya
        public static void Add_data_toBasa(string name, string sername, string fathername, string birthday, string id, string cins, string phonenumber, string mail, string parol)
        {

            pasient.Add(id);
            pasient.Add(parol);
            pasient.Add(fathername);
            pasient.Add(birthday);
            pasient.Add(name);
            pasient.Add(cins);
            pasient.Add(phonenumber);
            pasient.Add(mail);
            pasient.Add(sername);

        }
        public static ObservableCollection<ClassQeydiyyat>? pasients { get; set; } = new() { };
        static PasientlerDB()
        {
            pasients = ClassQeydiyyat.ReadData<ObservableCollection<ClassQeydiyyat>>("pasients");
        }
    }
}
