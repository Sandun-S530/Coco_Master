using Caliburn.Micro;
using Coco_Master.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Coco_Master
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
