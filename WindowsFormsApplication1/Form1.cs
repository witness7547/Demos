using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ConsoleManager.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string mystr = this.textBox1.Text;

            Thread myThread = new Thread(ThreadProc);
            myThread.Start(SynchronizationContext.Current);
        }

        private void ThreadProc(object obj)
        {
            //SynchronizationContext sc = (SynchronizationContext)obj;
            //sc.Post(Callback, "hello world!");
        }

        private void Callback(object str)
        {
            this.textBox1.Text = str.ToString();
        }
    }
}
