using HOSBITAL.Commands;
using HOSBITAL.Pages;
using HOSBITAL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOSBITAL.Views;
using Hospital.Views;
using Hospital.Pages;

namespace HOSBITAL.ViewModel
{
    public class ClassLogin
    {
        public RealCommand? qeydiyyatCommand { get; set; }
        public RealCommand? daxilOlCommand { get; set; }

        private void QeydiyyatButton(object? sender)
        {
            Qeydiyyat qeydiyyat = new Qeydiyyat();
            Girish.girish!.MainFrame.Content = qeydiyyat;
        }
        private void DaxilOl(object? param)
        {

            Pasientsexsikobinet pasientsexsikobinet = new Pasientsexsikobinet();
            pasientsexsikobinet.ShowDialog();
        }

        public ClassLogin() {
            qeydiyyatCommand = new(QeydiyyatButton);
            daxilOlCommand = new(DaxilOl);
        
        }
    }
}
