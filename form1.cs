using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace Matrix_Pattern
{
    public partial class Form1 : Form
    {
        
        Pen p = new Pen(Color.Red, 3);
        

        float i, j;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            resumeToolStripMenuItem.Enabled = false;
            th1 = new Thread(work);
            th1.Start();

            // MessageBox.Show("Start");
             g = this.CreateGraphics();
            Rectangle shape = new Rectangle(20, 34, 100, 45);
            

        }

        public void work()
        {
            while (true)
            {
                g.Clear(Color.White);
                for (int k = 0; k < size; k++)
                {
                    for (i = 0; i <= k; i++)
                    {

                        for (j = 0; j <= k; j++)
                        {
                            g.DrawRectangle(p, j * 50 + 60, i * 50 + 60, 50, 50);


                        }

                    }
                    Thread.Sleep(500);
                }
            }


        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            size = 6;
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th1.Resume();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            size = 3;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            size = 4;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            size = 5;

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            size = 7;

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            size = 8;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = true;
            resumeToolStripMenuItem.Enabled = true;
            th1.Suspend();
        }
    }
}
