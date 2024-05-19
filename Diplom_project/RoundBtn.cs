using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_project
{
    public class RoundBtn: Button
    {
        public int Radius { get; set; } = 30;

        private bool MouseEntered = false;
        private bool MousePressed = false;

        StringFormat SF = new StringFormat();

        // Pen pen;
        // SolidBrush brush;
        public RoundBtn()
        {
            SetStyle(

                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.SupportsTransparentBackColor |
                    ControlStyles.UserPaint,
                    true
            );

            DoubleBuffered = true;
          
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            MousePressed = false;
            Invalidate();
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width -1, Height - 1);
            GraphicsPath rectGp = RuundedRectangle(rect);

            g.FillPath(new SolidBrush(BackColor), rectGp);
            g.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

            if (MouseEntered)
            {
                g.FillPath(new SolidBrush(Color.FromArgb(50, Color.Black)), rectGp);
            }
            if (MousePressed)
            {
                g.FillPath(new SolidBrush(Color.FromArgb(70, Color.Black)), rectGp);
            }
        }

        GraphicsPath RuundedRectangle (Rectangle rect)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, Radius, Radius, 180, 90);
            gp.AddArc(rect.X + rect.Width - Radius, rect.Y, Radius, Radius, 270, 90);
            gp.AddArc(rect.X + rect.Width - Radius, rect.Y + rect.Height - Radius, Radius, Radius, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - Radius, Radius, Radius, 90, 90);

            gp.CloseFigure();
            return gp;
        }
    }
}
