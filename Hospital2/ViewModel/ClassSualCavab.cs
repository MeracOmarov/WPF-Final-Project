using HOSBITAL.Commands;
using Hospital.Pages;
using Hospital.Pasient;
using Hospital.Views;
using Hospital2.Models;
using Hospital2.Pages;
using Hospital2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSBITAL.ViewModel
{
    public class ClassSualCavab
    {
        public XesteSikayeti? xesteSikayeti { get; set; } = new();

        public RealCommand? sendCommand { get; set; }

        public void Send(object? param)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
            xesteSikayeti!.pasientSikayeti = PasientlerDB.CurrentPasient;
            SikayetlerViewModel.xesteSikayetleri.Add(xesteSikayeti);

            SikayetlerViewModel.WriteData(SikayetlerViewModel.xesteSikayetleri, "sikayetler");

        }

        public ClassSualCavab()
        {

            sendCommand = new RealCommand(Send);
        }
    }
}
