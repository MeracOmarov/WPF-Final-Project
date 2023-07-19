using HOSBITAL.Commands;
using Hospital.Pages;
using Hospital.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.ViewModel
{
    public class PasientClass
    {
        public RealCommand? onlineNovbeCommand { get; set; }

        private void OnlineNovbe(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Content = new Online_novbe();
        }

        public PasientClass()
        {
            onlineNovbeCommand = new(OnlineNovbe);
        }
    }
}
