using HOSBITAL.Commands;
using Hospital.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOSBITAL.Pages;
using Hospital.Pages;

namespace Hospital.ViewModel
{
    public class HekimClass
    {
        public RealCommand? xesteMuracietiCommand { get; set; }
        public RealCommand? xestelerCommand { get; set; }

        private void XesteMuracieti(object? param)
        {
            Hekimsexsikobinet.hekimsexsikobinet!.MainFrame.Content = new Muracietler();
        }
        private void Xesteler(object? param)
        {
            Hekimsexsikobinet.hekimsexsikobinet!.MainFrame.Content = new Pages.Xesteler();
        }
        public HekimClass()
        {
            xesteMuracietiCommand = new RealCommand(XesteMuracieti);
            xestelerCommand = new RealCommand(Xesteler);
        }
    }
}
