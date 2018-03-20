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
using System.Windows.Forms;

namespace ScreenTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rect rc = SystemParameters.WorkArea;//获取工作区大小  
            this.Left = 0;//设置位置  
            this.Top = 0;
            //this.Width = rc.Width;  
            //this.Height = rc.Height;

            this.Width = SystemParameters.PrimaryScreenWidth;
            this.Height = SystemParameters.PrimaryScreenHeight;

            Topmost = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void getScreenInfo_Click(object sender, RoutedEventArgs e)
        {
            //System.Windows.MessageBox.Show("width: " + SystemParameters.FullPrimaryScreenWidth.ToString() 
            //    + ", height: " + SystemParameters.FullPrimaryScreenHeight);

            //WpfScreen myScreen = WpfScreen.GetScreenFrom(this);

            ////myScreen.WorkingArea

            //this.Width = myScreen.DeviceBounds.Width;
            //this.Height = myScreen.DeviceBounds.Height;


            Taskbar.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Taskbar.Show();
        }
    }
}
