using HOSBITAL.Commands;
using HOSBITAL.Views;
using Hospital.Pages;
using Hospital.Views;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSBITAL.ViewModel
{
    public class ClassOnlineNovbe
    {
        public RealCommand ?tamamlaCommand { get; set; }
        public RealCommand ?Close_command { get; set; }


        public XesteMuracieti xesteMuracieti { get; set; }
        private void Tamamla(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }

        private void Close(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }

        public ClassOnlineNovbe()
        {
            tamamlaCommand = new RealCommand(Tamamla);
            Close_command = new RealCommand(Tamamla);
        }
    }
}
