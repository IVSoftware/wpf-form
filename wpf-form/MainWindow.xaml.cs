﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Form = IVSoftware.Form;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// REFERENCE: https://www.c-sharpcorner.com/UploadFile/mahakgupta/simple-data-binding-in-wpf/
namespace wpf_window_ex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnLoad(RoutedEventArgs e)
        {
            base.OnLoad(e);
            textBox.AppendText("Loaded." + Environment.NewLine);
        }
    }
}
