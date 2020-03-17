﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using MVVMSidekick.Views;
using Samples.ViewModels;

namespace Samples
{
    public partial class MainPage : MVVMPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            ((Panel)this.Content).DataContext = new Index_Model();
        }
    }
}