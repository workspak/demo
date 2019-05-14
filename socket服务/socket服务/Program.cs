using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace socket服务
{
    
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Method();
            Console.ReadLine();
        }



        #region 测试代码
        //public delegate void FunctionOne(object obj); 类同级
        //static FunctionOne fo;
        //static void Main(string[] args)
        //{
        //    fo = new FunctionOne(Method);
        //    fo("1231312312aaaadawdwa");
        //    Console.ReadLine();
        //}

        //private static void Method(object obj)
        //{
        //    Console.WriteLine(obj);
        //}
        //线程代码
        BackgroundWorker _workerThread;
        void Method()
        {
            _workerThread = new BackgroundWorker();
            _workerThread.DoWork += new DoWorkEventHandler(_workerThread_DoWork);
            _workerThread.RunWorkerCompleted += _workerThread_RunWorkerCompleted;
            _workerThread.RunWorkerAsync(1231231);
        }

        private void _workerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Work Completed");
        }

        private void _workerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine(e.Argument+"Working");
        }
        #endregion
    }
}
