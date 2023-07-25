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
        public RealCommand? xestelerCommand { get; set; }

        private void Xesteler(object? param)
        {
            Hekimsexsikobinet.hekimsexsikobinet!.MainFrame.Content = new Pages.Xesteler();
        }
        public HekimClass()
        {
            xestelerCommand = new RealCommand(Xesteler);
        }
    }
}
