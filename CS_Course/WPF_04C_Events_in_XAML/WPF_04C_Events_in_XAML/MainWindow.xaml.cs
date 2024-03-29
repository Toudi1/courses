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

namespace WPF_04C_Events_in_XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked - Direct Event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up - was released - Bubbling event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up - was released - Tuneling event");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Left mouse button went down - was released - Tuneling event");
        }

        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right mouse button went down - was released - Tuneling event");
        }
    }
}
