using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace klaseProcesIvaSosic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("msedge.exe")
            {
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = "www.sser.hr"
            };
            Process.Start(startInfo);
        }
    }
}
    