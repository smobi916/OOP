using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParametricCurvePlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            float a;
            if (float.TryParse(txtA.Text, out a))
            {
                pnlGraph.Invalidate(); // Перемальовує панель графіка
            }
            else
            {
                MessageBox.Show("Please enter a valid number for 'a'.");
            }
        }

        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float a;
            if (!float.TryParse(txtA.Text, out a)) return;

            // Задаємо параметри графіка
            int width = pnlGraph.Width;
            int height = pnlGraph.Height;
            int centerX = width / 2;
            int centerY = height / 2;

            // Малюємо систему координат
            g.DrawLine(Pens.Black, 0, centerY, width, centerY); // X-axis
            g.DrawLine(Pens.Black, centerX, 0, centerX, height); // Y-axis

            // Підписи осей
            Font font = new Font("Arial", 8);
            g.DrawString("X", font, Brushes.Black, width - 10, centerY + 5);
            g.DrawString("Y", font, Brushes.Black, centerX - 10, 5);

            // Малюємо графік функції
            float tMin = 0;
            float tMax = (float)(2 * Math.PI);
            float step = 0.01f;

            PointF? prevPoint = null;
            for (float t = tMin; t <= tMax; t += step)
            {
                float x = (float)(a * Math.Cos(t) * (1 + Math.Cos(t)));
                float y = (float)(a * Math.Sin(t) * (1 + Math.Cos(t)));

                // Перетворення координат для малювання на панелі
                PointF point = new PointF(centerX + x * 10, centerY - y * 10); // Масштабування для кращого вигляду

                if (prevPoint.HasValue)
                {
                    g.DrawLine(Pens.Red, prevPoint.Value, point);
                }

                prevPoint = point;
            }
        }
    }
}
