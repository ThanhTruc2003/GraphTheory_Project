using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphTheory_Project
{
    public partial class GraphTheory_Project : Form
    {
        public GraphTheory_Project()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p1 = new Pen(Color.SkyBlue, 8);
            Pen p2 = new Pen(Color.SkyBlue, 8);
            g.DrawRectangle(p1, 12, 12, 688, 586);
            g.DrawRectangle(p2, 721, 12, 417, 586);
        }
    }
}