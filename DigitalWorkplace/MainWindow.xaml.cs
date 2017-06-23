using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppBar;

namespace DigitalWorkplace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            Height = SystemParameters.PrimaryScreenHeight;
            Left = SystemParameters.PrimaryScreenWidth - 50;
            timer = new Timer(1);
            timer.Start();
            timer.AutoReset = false;
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke((Action)delegate()
            {
                AppBarFunctions.SetAppBar(this, ABEdge.Right);
            });
        }
    }
}
