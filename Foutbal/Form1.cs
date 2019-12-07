using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Foutbal
{
    public partial class Form1 : Form
    {
        SoccerStars ob;
        public Form1()
        {
            InitializeComponent();
            ob = new SoccerStars(pictureBox1.Width, pictureBox1.Height);
        }
   
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "     " + e.Y;
            ob.MouseMove(e.X, e.Y, pictureBox1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ob.MouseDown(e.X, e.Y);
        }
        bool mouseup = false;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ob.MouseUp(e.X, e.Y, pictureBox1,ref mouseup);
            if (mouseup) {   timer1.Start();   }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.Hisoblash();
            ob.Chizish(pictureBox1);
        }
        bool vaqt = false; int sekund = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sekund++;
            ob.Yurgazish(sekund, ref vaqt, pictureBox1,label2);
            if (vaqt)
            {
                timer1.Stop(); vaqt = false;
                ob.Tozalash();
                label2.Text = "";
            }
        }

        private void taktikaAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.Taktika_A(pictureBox1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}