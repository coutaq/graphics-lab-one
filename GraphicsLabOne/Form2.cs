using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLabOne
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Получаем объект Graphics 
            Graphics g = e.Graphics;
            // Рисуем линию 
            g.DrawLine(Pens.Red, 10, 5, 110, 15);
            // Рисуем эллипс 
            g.DrawEllipse(Pens.Blue, 10, 20, 110, 45);
            // Рисуем прямоугольник 
            g.DrawRectangle(Pens.Green, 10, 70, 110, 45);
            // Рисуем закрашенный эллипс 
            g.FillEllipse(Brushes.Blue, 130, 20, 110, 45);
            // Рисуем закрашенный прямоугольник 
            g.FillRectangle(Brushes.Green, 130, 70, 110, 45);
            base.OnPaint(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
