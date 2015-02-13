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
    [DesignerAttribute(typeof(LinkDesigner))]
    public partial class Link : Shape
    {
        const byte indent = 2;

        private Point start;
        public Point Start
        {
            get
            {
                return start;
            }
            set
            {
                if (value.X > end.X) return;
                start = value;
                AdjustControl();
            }
        }

        private Point end;
        public Point End
        {
            get
            {
                return end;
            }
            set
            {
                if (value.X < start.X) return;
                end = value;
                AdjustControl();
            }
        }

        private void AdjustClipRegion()
        {
            // Limit region to draw/clip
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int x1, y1, x2, y2, x3, y3, x4, y4;
            if (start.Y < end.Y)
            {
                x1 = 2 * indent;
                y1 = 0;
                x2 = Width - 1;
                y2 = Height - 2 * indent - 1;
                x3 = Width - 2 * indent - 1;
                y3 = Height - 1;
                x4 = 0;
                y4 = 2 * indent;
            }
            else
            {
                x1 = 0;
                y1 = Height - 2 * indent - 1;
                x2 = Width - 2 * indent - 1;
                y2 = 0;
                x3 = Width - 1;
                y3 = 2 * indent;
                x4 = 2 * indent;
                y4 = Height - 1;
            }
            Point[] clipPolygon = new Point[] { 
                new Point(x1, y1), new Point(x2, y2), 
                new Point(x3, y3), new Point(x4, y4) };
            path.AddPolygon(clipPolygon);
            this.Region = new System.Drawing.Region(path);
        }
        
        private void AdjustControl()
        {
            Left = start.X - indent;
            Width = end.X - start.X + 2 * indent;
            if (start.Y < end.Y)
            {
                Top = start.Y - indent;
                Height = end.Y - start.Y + 2 * indent;
            }
            else
            {
                Top = end.Y - indent;
                Height = start.Y - end.Y + 2 * indent;
            }

            AdjustClipRegion();
        }

        public Link()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            if (Selected)
            {
                p.Width = 2F;
            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int x1, y1, x2, y2;
            x1 = indent;
            x2 = this.Width - indent - 1;
            if (start.Y < end.Y)
            {
                y1 = indent;
                y2 = this.Height - indent - 1;
            }
            else
            {
                y1 = this.Height - indent - 1;
                y2 = indent;
            }
            e.Graphics.DrawLine(p, x1, y1, x2, y2);
        }
    }
}
