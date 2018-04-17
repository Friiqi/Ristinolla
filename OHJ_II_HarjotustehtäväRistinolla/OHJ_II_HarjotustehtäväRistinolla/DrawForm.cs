using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHJ_II_HarjotustehtäväRistinolla
{
    public partial class DrawForm : Form
    {
        
        public DrawForm()
        {
            InitializeComponent();
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {
           
       
        }

        private void DrawForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush lgrayBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightGray);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(lgrayBrush, new Rectangle(0, 0, 816, 489));
            lgrayBrush.Dispose();
            Brush whiteBrush = new SolidBrush(Color.White);
            formGraphics.FillRectangle(whiteBrush, new Rectangle(100,70 , 600, 300));
            whiteBrush.Dispose();
            Pen blackPen = new Pen(Color.Black, 5);
            formGraphics.DrawLine(blackPen, 300, 70, 300, 370);
            formGraphics.DrawLine(blackPen, 500, 70, 500, 370);
            formGraphics.DrawLine(blackPen, 100, 170, 700, 170);
            formGraphics.DrawLine(blackPen, 100, 270, 700, 270);
            blackPen.Dispose();
            
            formGraphics.Dispose();
        }

        private void DrawForm_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = PointToClient(Cursor.Position).ToString();
            Point mouseCurrent = PointToClient(Cursor.Position);
            if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170))
                {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 100, 70, 300, 170);
                drawX.DrawLine(blackPen, 300, 70, 100, 170);
              
                blackPen.Dispose();
                drawX.Dispose();
                
            }
            if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 300, 70, 500, 170);
                drawX.DrawLine(blackPen, 500, 70, 300, 170);
                blackPen.Dispose();
                drawX.Dispose();
            }
            if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 500, 70, 700, 170);
                drawX.DrawLine(blackPen, 700, 70, 500, 170);
                blackPen.Dispose();
                drawX.Dispose();

            }
            if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 100, 170, 300, 270);
                drawX.DrawLine(blackPen, 300, 170, 100, 270);
                blackPen.Dispose();
                drawX.Dispose();

            }
            if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 300, 170, 500, 270);
                drawX.DrawLine(blackPen, 500, 170, 300, 270);
                blackPen.Dispose();
                drawX.Dispose();
            }
            if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 500, 170, 700, 270);
                drawX.DrawLine(blackPen, 700, 170, 500, 270);
                blackPen.Dispose();
                drawX.Dispose();

            }
            if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 100, 270, 300, 370);
                drawX.DrawLine(blackPen, 300, 270, 100, 370);
                blackPen.Dispose();
                drawX.Dispose();

            }
            if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 300, 270, 500, 370);
                drawX.DrawLine(blackPen, 500, 270, 300, 370);
                blackPen.Dispose();
                drawX.Dispose();
            }
            if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370))
            {
                Graphics drawX;
                drawX = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawX.DrawLine(blackPen, 500, 270, 700, 370);
                drawX.DrawLine(blackPen, 700, 270, 500, 370);
                blackPen.Dispose();
                drawX.Dispose();

            }

            if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 150, 70, 100, 100);
                
                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 350, 70, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 70) && (mouseCurrent.Y < 170))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 550, 70, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 150, 170, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 350, 170, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 170) && (mouseCurrent.Y < 270))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 550, 170, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 100) && (mouseCurrent.X < 300) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 150, 270, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 300) && (mouseCurrent.X < 500) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 350, 270, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
            if ((mouseCurrent.X > 500) && (mouseCurrent.X < 700) && (mouseCurrent.Y > 270) && (mouseCurrent.Y < 370))
            {
                Graphics drawEllipse;
                drawEllipse = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 5);
                drawEllipse.DrawEllipse(blackPen, 550, 270, 100, 100);

                blackPen.Dispose();
                drawEllipse.Dispose();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
