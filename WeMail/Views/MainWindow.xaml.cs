using System.Windows;
using System.Windows.Input;

namespace WeMail.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            menuBar.SelectionChanged += (s, e) =>
            {
                drawerHost.IsLeftDrawerOpen = false;
            };

            btnMin.Click += (s,e) => { 
                this.WindowState = WindowState.Minimized;
            };
            btnMax.Click += (s, e) => {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                }
                else
                { this.WindowState = WindowState.Maximized; }

            };
            btnCls.Click += (s, e) => { this.Close(); };
            colorZone.MouseMove += (s, e) =>
            {
                if(e.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
            };
            colorZone.MouseDoubleClick += (s, e) =>
            {
                if (this.WindowState == WindowState.Normal)
                {
                    this.WindowState = WindowState.Maximized;
                }
                else
                { this.WindowState = WindowState.Normal; }
            };
        }

    }
}
