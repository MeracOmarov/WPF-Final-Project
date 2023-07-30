using HOSBITAL.ViewModel;
using Hospital.Pasient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.Models
{
    public class HekimlerDB
    {
        public static void Add_data_toBasa(Hekimler hekimler)
        {
            HekimlerDB.hekimler!.Add(hekimler);
            ClassQeydiyyat.WriteData(HekimlerDB.hekimler, "doctors");
        }
        public static ObservableCollection<Hekimler>? hekimler { get; set; } = new()  {
                new Hekimler() {
                    doctorName ="Ibrahim"
                },
                new Hekimler() {
                    doctorName ="Merac"
                },
                 new Hekimler() {
                    doctorName ="Hesen"
                },
                  new Hekimler() {
                    doctorName ="Rustem "
                },

            };
        static HekimlerDB()
        {
            hekimler = ClassQeydiyyat.ReadData<ObservableCollection<Hekimler>>("doctors");
        }
        public HekimlerDB()
        {
            hekimler = ClassQeydiyyat.ReadData<ObservableCollection<Hekimler>>("doctors");
        }
    }
}
