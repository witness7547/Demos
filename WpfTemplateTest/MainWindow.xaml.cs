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

namespace WpfTemplateTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MyCar> mycars = new List<MyCar>();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = mycars;
            mycars.Add(new MyCar("2000", "100"));
            mycars.Add(new MyCar("2001", "80"));
            mycars.Add(new MyCar("2002", "80"));
            mycars.Add(new MyCar("2003", "90"));
            mycars.Add(new MyCar("2004", "120"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread myThread = new Thread(ThreadProc);
            myThread.Start(SynchronizationContext.Current);
        }

       
        private void ThreadProc(object obj)
        {
            // throw invid operation exception
            //Callback("121");


            //SynchronizationContext sc = (SynchronizationContext)obj;
            //sc.Post(Callback, "hello world!");


            this.Dispatcher.Invoke(() => { Callback("hello world"); });

        }

        private void Callback(object str)
        {
            try
            {
                this.btn1.Content = str.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
