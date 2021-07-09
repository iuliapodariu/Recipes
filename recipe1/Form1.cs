using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe1
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
        }
     
        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void Form1_Load(object sender, PaintEventArgs e)
        {

        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value; };
            flowLayoutPanel1.Controls.Add(vScrollBar1);
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { flowLayoutPanel1.VerticalScroll.Value = vScrollBar1.Value; };
            flowLayoutPanel1.Controls.Add(vScrollBar1);
        }

        private void aDAUGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adauga openForm = new Adauga();
            openForm.Show();
        }
        private void panel1_Paint_Click(object sender, EventArgs e)
        {
            //string message = "Simple MessageBox";
            // string title = "Title";
            // MessageBox.Show(message, title);
        
        }
    }
}
