using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Xpf.Core;

namespace Scaffolding.WCF {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e) {
            ApplicationThemeHelper.UpdateApplicationThemeName();
        }
        protected override void OnExit(ExitEventArgs e) {
            ApplicationThemeHelper.SaveApplicationThemeName();
        }
    }
}
