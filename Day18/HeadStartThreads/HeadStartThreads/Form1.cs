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
            int end = (num + 1) * 50;
            for (int i = num*50; i < end; i++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();
            var task = Task.Factory.StartNew(() => PrintSleep());
            var task2 = Task.Factory.StartNew(() => PrintSleep());
            var task3 = Task.Factory.StartNew(() => PrintSleep());

            Task.WaitAll(task, task2, task3);
            watch.Stop();
            MessageBox.Show(watch.ElapsedMilliseconds.ToString());
        }

        private void PrintSleep()
        {
            Thread.Sleep(1000);
            Console.WriteLine("HI");
            throw new Exception("gghgh");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
            watch.Stop();
            MessageBox.Show(watch.ElapsedMilliseconds.ToString());
            Console.WriteLine("hiyaaa");
            watch.Reset();
            watch.Start();
            Parallel.For(0, 1000, i => Console.WriteLine(i));
            MessageBox.Show(watch.ElapsedMilliseconds.ToString());
            Console.WriteLine("hiyaaa");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var task = Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 10000; i++)
                    {
                        if (token.IsCancellationRequested)
                        {
                            Console.WriteLine("Byeeee");
                            return;
                        }
                        else
                            Console.WriteLine(i);
                    }
                    
                },token);

            tokenSource.Cancel();

        }


    }
}
