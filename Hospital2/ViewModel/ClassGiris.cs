using HOSBITAL.Commands;
using HOSBITAL.Pages;
using HOSBITAL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HOSBITAL.ViewModel
{
    public class ClassGiris
    {
        public RealCommand? daxilOlCommand { get; set; }
        private void DaxilOl(object? sender)
        {
            Girish.girish!.MainFrame.Content = new Login();
        } 
        public ClassGiris()
        {
            daxilOlCommand = new RealCommand(DaxilOl);
        }
    }
}
