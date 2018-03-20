using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SplashScreenTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SplashScreen splashScreen = new SplashScreen("1.jpg");
            splashScreen.Show(false);

            //Thread.Sleep(3000);

            splashScreen.Close(new TimeSpan(0, 0, 10));

            CallTestMethod();
        }

        private void CallTestMethod()
        {
            Class1 c1 = new Class1();
            c1.Test();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Class1 c1 = new Class1();
            c1 = null;
            MessageBox.Show(c1?.Test1());
        }
    }
}
