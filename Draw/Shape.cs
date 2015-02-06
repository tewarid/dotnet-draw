using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public abstract partial class Shape : UserControl
    {
        bool selected = false;
        bool moving = false;
        int leftOffset;
        int topOffset;

        public Shape()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.MouseDown += Shape_MouseDown;
            this.MouseUp += Shape_MouseUp;
            this.MouseClick += Shape_MouseClick;
            this.MouseMove += Shape_MouseMove;
        }

        void Shape_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        void Shape_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Left = Left + e.X - leftOffset;
                Top = Top + e.Y - topOffset;
            }
        }

        void Shape_MouseClick(object sender, MouseEventArgs e)
        {
            selected = true;
            Refresh();
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip.Show(PointToScreen(new Point(e.X, e.Y)));
            }
        }

        void Shape_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            selected = true;
            leftOffset = e.X;
            topOffset = e.Y;
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle r = new Rectangle(3, 3, this.Width - 6, this.Height - 6);
            e.Graphics.DrawRectangle(Pens.Black, r);
            if (selected)
            {
                Rectangle s = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
                e.Graphics.DrawRectangle(Pens.DarkBlue, s);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
