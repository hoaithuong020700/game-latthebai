using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Memory_Game
{
    //TRẦN THỊ HOÀI THƯƠNG
    public partial class FrmScreen : Form
    {
        int x = 0;
        public FrmScreen()
        {
            InitializeComponent();
            timer1.Start();
            x = 1;
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 300;
            progressBar1.Maximum = 10000;
            progressBar1.Step = 100;
            lblPhanTram.Text = x.ToString();
            progressBar1.PerformStep();
            if (x == 101)
            {
                timer1.Stop();
                FrmMain f = new FrmMain();
                f.Show();
                this.Hide();
            }
            x = x + 1;
        }
    }
}