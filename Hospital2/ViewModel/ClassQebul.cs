using HOSBITAL.Commands;
using Hospital.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSBITAL.ViewModel
{
    public class ClassQebul
    {
        public string ?Xestexana { get; set; }
        public string ?Muayine { get; set; }
        public string ?Hekim { get; set; }

        public RealCommand? tamamlandiButton { get; set; }
        public RealCommand? Close_command { get; set; }

        private void Tamamlandi(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }
        private void Close(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }

        public ClassQebul()
        {
            tamamlandiButton = new RealCommand(Tamamlandi);
            Close_command = new RealCommand(Close);
        }




    }
}
