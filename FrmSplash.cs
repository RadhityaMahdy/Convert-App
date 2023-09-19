using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_App
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerleft > 0)
            {
                timerleft = timerleft - 1;   
            }
            else
            {
                timer1.Stop();
                new FrmMenu().Show();
                this.Hide();
            }
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timerleft = 3;
            timer1.Start();
        }
        public int timerleft
        {
            get; 
            set;   
        }
    }
}
