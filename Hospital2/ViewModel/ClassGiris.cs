using HOSBITAL.Commands;
using HOSBITAL.Pages;
using HOSBITAL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hospital.Views;

namespace HOSBITAL.ViewModel
{
    public class ClassGiris
    {
        public RealCommand? daxilOlCommand { get; set; }
        public RealCommand? hekimlerCommand { get; set; }
        private void DaxilOl(object? sender)
        {
            Girish.girish!.MainFrame.Content = new Login();
        }

        private void Hekimler(object? sender)
        {
            Hekimsexsikobinet hekimsexsikobinet = new Hekimsexsikobinet();
            hekimsexsikobinet.ShowDialog();
        }
        public ClassGiris()
        {
            daxilOlCommand = new RealCommand(DaxilOl);
            hekimlerCommand = new RealCommand(Hekimler);
        }
    }
}
