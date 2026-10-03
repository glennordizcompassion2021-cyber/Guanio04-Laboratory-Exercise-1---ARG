using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            lblStatus.Text = "-Before starting thread-";

            Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            lblStatus.Text = "-End of Thread-";
        }
    }
}
