using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadStartThreads
{
    public partial class Form1 : Form
    {
        DateTime start;
        int _counter = 0;
        object _locker = new object();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLongSynchronusTask_Click(object sender, EventArgs e)
        {
            //Print();
            start = DateTime.Now;
            for (int i = 0; i < 500; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(Print));
                thread.Start(i);
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(Print),i);
            //}
            
        }

        private void Print(object number)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            int num = Convert.ToInt32(number);
            int end = (num + 1) * 500;
            for (int i = num*500; i < end; i++)
            {
                Console.WriteLine(i);
            }
            lock (_locker)
	        {
		        _counter++;
	        }
            //watch.Stop();
            //MessageBox.Show(watch.ElapsedMilliseconds.ToString());
            this.Invoke(new MethodInvoker(() => lblTime.Text = (DateTime.Now - start).ToString()));
        }
    }
}
