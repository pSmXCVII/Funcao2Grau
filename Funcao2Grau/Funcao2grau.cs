using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class frm_funcao_quadratica : Form
    {
        public frm_funcao_quadratica()
        {
            InitializeComponent();
        }

        private void TextBox_KeyPress_Numeric(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
                    
                if (e.KeyChar == '-')
                {
                    if (textBox.Text.Contains("-") || textBox.SelectionStart != 0)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_a.KeyPress += TextBox_KeyPress_Numeric;
            tb_b.KeyPress += TextBox_KeyPress_Numeric;
            tb_c.KeyPress += TextBox_KeyPress_Numeric;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(this.tb_a.Text);
                double b = Convert.ToDouble(this.tb_b.Text);
                double c = Convert.ToDouble(this.tb_c.Text);

                double delta = CalcularDelta(a, b, c);
                this.tb_delta.Text = Convert.ToString(delta);

                if (delta < 0)
                {
                    this.chart_raizes.Series.Clear();
                    this.tb_x1.Text = "Não existem raízes reais.";
                    this.tb_x2.Text = "Não existem raízes reais.";
                }
                else
                {
                    double[] raizes = CalcularRaizes(a, b, delta);
                    this.tb_x1.Text = Convert.ToString(raizes[0]);
                    this.tb_x2.Text = Convert.ToString(raizes[1]);
                    DesenharGrafico(a, b, c, raizes[0], raizes[1]);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularDelta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        private double[] CalcularRaizes(double a, double b, double delta)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { x1, x2 };
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            this.tb_a.Text = "";
            this.tb_b.Text = "";
            this.tb_c.Text = "";
            this.tb_delta.Text = "";
            this.tb_x1.Text = "";
            this.tb_x2.Text = "";
            this.chart_raizes.Series.Clear();
            this.chart_raizes.Visible = false;
        }

        private void DesenharGrafico(double a, double b, double c, double x1, double x2)
        {
            this.chart_raizes.Series.Clear();
            this.chart_raizes.Visible = true;

            Series serieParabola = new Series
            {
                Name = "Parábola",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };

            Series serieRaizes = new Series
            {
                Name = "Raízes",
                Color = System.Drawing.Color.Red,
                ChartType = SeriesChartType.Point,
                MarkerSize = 5,
                IsValueShownAsLabel = true,
                LabelForeColor = System.Drawing.Color.Black
            };

            Series serieLinhaX = new Series
            {
                Name = "Linha X",
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };

            Series serieLinhaY = new Series
            {
                Name = "Linha Y",
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };

            this.chart_raizes.Series.Add(serieLinhaX);
            this.chart_raizes.Series.Add(serieLinhaY);
            this.chart_raizes.Series.Add(serieParabola);
            this.chart_raizes.Series.Add(serieRaizes);

            double step = 1;
            double minX = Math.Min(x1, x2) - 5;
            double maxX = Math.Max(x1, x2) + 5;

            if (maxX - minX < 2 * step)
            {
                double middleX = (minX + maxX) / 2;
                minX = middleX - step;
                maxX = middleX + step;
            }

            double minY = double.MaxValue;
            double maxY = double.MinValue;

            for (double x = minX; x <= maxX; x += step)
            {
                double y = a * x * x + b * x + c;
                minY = Math.Min(minY, y);
                maxY = Math.Max(maxY, y);
            }

            double paddingY = Math.Max(Math.Abs(minY), Math.Abs(maxY)) * 0.2;
            this.chart_raizes.ChartAreas[0].AxisY.Minimum = minY - paddingY;
            this.chart_raizes.ChartAreas[0].AxisY.Maximum = maxY + paddingY;

            for (double x = minX; x <= maxX; x += step)
            {
                double y = a * x * x + b * x + c;
                serieParabola.Points.AddXY(x, y);
            }

            var pontoX1 = serieRaizes.Points.AddXY(x1, 0);
            serieRaizes.Points[pontoX1].Label = "X1 = " + x1;

            var pontoX2 = serieRaizes.Points.AddXY(x2, 0);
            serieRaizes.Points[pontoX2].Label = "X2 = " + x2;


            serieLinhaX.Points.AddXY(minX, 0);
            serieLinhaX.Points.AddXY(maxX, 0);

            serieLinhaY.Points.AddXY(0, minY - paddingY);
            serieLinhaY.Points.AddXY(0, maxY + paddingY);

            var chartArea = this.chart_raizes.ChartAreas[0];
            chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;

            this.chart_raizes.Invalidate();
        }

    }
}
