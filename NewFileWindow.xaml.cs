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
using System.Windows.Shapes;

namespace FileMangement
{
    /// <summary>
    /// NewFileWindow.xaml 的交互逻辑
    /// </summary>
    public partial class NewFileWindow : Window
    {
        public string _newFileName;

        public NewFileWindow()
        {
            InitializeComponent();
        }

        private void NewFileName_Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            _newFileName = NewFileName_Text.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}