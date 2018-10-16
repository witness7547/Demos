using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace AsyncTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Mark the event handler with async so you can use await in it.
        private async void startBtn_Click(object sender, RoutedEventArgs e)
        {
            // Call and await separately.  
            //Task<int> getLengthTask = AccessTheWebAsync();  
            //// You can do independent work here.  
            //int contentLength = await getLengthTask;  

            int contentLength = await AccessTheWebAsync();

            resultsTextBox.Text +=
                String.Format("\r\nLength of the downloaded string: {0}.\r\n", contentLength);
        }

        // Three things to note in the signature:  
        //  - The method has an async modifier.   
        //  - The return type is Task or Task<T>. (See "Return Types" section.)  
        //    Here, it is Task<int> because the return statement returns an integer.  
        //  - The method name ends in "Async."  
        async Task<int> AccessTheWebAsync()
        {
            // You need to add a reference to System.Net.Http to declare client.  
            HttpClient client = new HttpClient();

            // GetStringAsync returns a Task<string>. That means that when you await the  
            // task you'll get a string (urlContents).  
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");//******************************** I/O-Bound ***

            // You can do work here that doesn't rely on the string from GetStringAsync.  
            DoIndependentWork();

            // The await operator suspends AccessTheWebAsync.  
            //  - AccessTheWebAsync can't continue until getStringTask is complete.  
            //  - Meanwhile, control returns to the caller of AccessTheWebAsync.  
            //  - Control resumes here when getStringTask is complete.   
            //  - The await operator then retrieves the string result from getStringTask.  
            string urlContents = await getStringTask;

            resultsTextBox.Text = urlContents;

            // The return statement specifies an integer result.  
            // Any methods that are awaiting AccessTheWebAsync retrieve the length value.  
            return urlContents.Length;
        }

        void DoIndependentWork()
        {
            resultsTextBox.Text += "Working . . . . . . .\r\n";
        }

        private async void calculateBtn_Click(object sender, RoutedEventArgs e)
        {
            resultsTextBox.Text = "Calculating . . . . ";

            // This line will yield control to the UI while CalculateDamageDone()
            // performs its work.  The UI thread is free to perform other work.
            var result = await Task.Run(() => 
            {
                // … do Compute-bound work here
                return CalculateDamageDone();//********************************************************************************** CPU-Bound ***
            });

            resultsTextBox.Text = "Result of damage calculating: " + result.ToString();
        }

        private DamageResult CalculateDamageDone()
        {
            // Code omitted:
            //
            // Does an expensive calculation and returns
            // the result of that calculation.
            
            //simulate the calculation
            System.Threading.Thread.Sleep(2000);

            return new DamageResult(100);
        }

        class DamageResult
        {
            public int result;
            public DamageResult(int r)
            {
                result = r;
            }

            public override string ToString()
            {
                return this.result.ToString();
            }
        }
    }
}
