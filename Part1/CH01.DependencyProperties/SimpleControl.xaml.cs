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

namespace CH01.DependencyProperties
{
    /// <summary>
    /// Interaction logic for SimpleControl.xaml
    /// </summary>
    public partial class SimpleControl : UserControl
    {
        public SimpleControl()
        {
            InitializeComponent();
        }



        public int YearPublished
        {
            get { return (int)GetValue(YearPublishedProperty); }
            set { SetValue(YearPublishedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for YearPublished.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YearPublishedProperty =
            DependencyProperty.Register(
                "YearPublished", 
                typeof(int), 
                typeof(SimpleControl), 
                new UIPropertyMetadata(2000, OnValueChanged));

        /*to make this property inheritable by default*/
        //public static readonly DependencyProperty YearPublishedProperty =
        //    DependencyProperty.Register(
        //        "YearPublished", 
        //        typeof(int), 
        //        typeof(SimpleControl), 
        //        new FrameworkPropertyMetadata(2000, FrameworkPropertyMetadataOptions.Inherits));

        private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            // do something when property changes 
            
        }
    }
}
