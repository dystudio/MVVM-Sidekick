﻿using MVVMSidekick.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
//using Windows.UI.Xaml;

namespace MVVMSidekick.Views 
{
    /// <summary>
    /// Interface IView
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Gets or sets the view model.
        /// </summary>
        /// <value>The view model.</value>
        IViewModel ViewModel { get; set; }



        /// <summary>
        /// Gets or sets the content object.
        /// </summary>
        /// <value>The content object.</value>
        Object ViewContentObject { get; set; }

        Object ViewObject { get; }
        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        object  Parent { get; }

        void SelfClose();
    }
    
}
