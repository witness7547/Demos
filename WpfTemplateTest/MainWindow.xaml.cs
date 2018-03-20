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
    }
}
