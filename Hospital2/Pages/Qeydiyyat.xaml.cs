﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HOSBITAL.ViewModel;

namespace Hospital.Pages
{
    
    public partial class Qeydiyyat : Page
    {
        public static Qeydiyyat? qeydiyyat_pasient;
        public ClassQeydiyyat pasient_qeydiyyat = new();
        public Qeydiyyat()
        {
            InitializeComponent();
            DataContext = new ClassQeydiyyat();
            qeydiyyat_pasient = this;
        }
    }
}
