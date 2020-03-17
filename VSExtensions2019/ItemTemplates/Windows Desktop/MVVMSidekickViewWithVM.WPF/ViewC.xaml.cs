﻿using System.Reactive;
using System.Reactive.Linq;
using MVVMSidekick.ViewModels;
using MVVMSidekick.Views;
using MVVMSidekick.Reactive;
using MVVMSidekick.Services;
using MVVMSidekick.Commands;
using $rootnamespace$;
using $rootnamespace$.ViewModels;  
using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
$if$ ($targetframeworkversion$ >= 4.5)using System.Threading.Tasks;
$endif$using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace $rootnamespace$
{
    /// <summary>
    /// Interaction logic for $safeitemname$.xaml
    /// </summary>
    public partial class $safeitemname$ : UserControl
    {
        public $safeitemname$()
		{

			InitializeComponent();
        }

        public ControlViewDisguise ViewDisguise { get { return this.GetOrCreateViewDisguise(); } }
    }
}

