using System;
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
using CefSharp;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for ChromiumWebBrowser.xaml
    /// </summary>
    public partial class ChromiumWebBrowser : Page
    {
        public ChromiumWebBrowser()
        {
            CefSettings setting = new CefSettings();
            setting.RemoteDebuggingPort = 8080;
            if(!Cef.IsInitialized)
                Cef.Initialize(setting);
            InitializeComponent();
        }
    }
}
