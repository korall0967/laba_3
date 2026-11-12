using ScottPlot;

namespace laba_3
{
    public partial class Form1 : Form
    {
        private ScottPlot.Plottables.Scatter line;
        private double MinV;
        private double MaxV;
        private int PointsCount;
        private ScottPlot.Color Color = ScottPlot.Colors.Blue;
        private List<MarkerData> markers = new List<MarkerData>();
        private double Function(double x)
        {
            double l0 = 100.05;
            double c = 300000.0;

            return l0 * Math.Sqrt(1 - (x * x) / (c * c));

        }
        private void DataUpgrate()
        {

            double[] xData = new double[PointsCount];
            double[] yData = new double[PointsCount];

            for (int i = 0; i < PointsCount; i++)
            {
                double v = MinV + i * ((MaxV - MinV) / (PointsCount - 1));
                xData[i] = v;
                yData[i] = Function(v);
            }

            formsPlot1.Plot.Clear();

            line = formsPlot1.Plot.Add.Scatter(xData, yData);
            line.MarkerStyle = ScottPlot.MarkerStyle.None;
            line.Color = Color;

            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }
        private void Oblast()
        {
            var a = (int)numericUpDown2.Value;
            var b = (int)numericUpDown3.Value;

            if (a < b)
            {
                MinV = a; MaxV = b;
            }

            DataUpgrate();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            line.LineWidth = (float)numericUpDown1.Value;
            formsPlot1.Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Oblast();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Oblast();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            PointsCount = (int)numericUpDown4.Value;
            if (PointsCount > 1)
            {
                DataUpgrate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (line != null)
                {
                    button1.BackColor = colorDialog1.Color;
                    Color = ScottPlot.Color.FromColor(colorDialog1.Color);
                    DataUpgrate();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string name = form.MarkerName;
                double V = form.MarkerV;
                double L = Function(V);
                var marker = new MarkerData(name, V, L);
                markers.Add(marker);

                listBox1.Items.Add($"{name} V={V:F1}, L= {L:F1}");

                var m = formsPlot1.Plot.Add.Marker(V, L);
                m.LegendText = name;
                formsPlot1.Plot.ShowLegend();
                formsPlot1.Refresh();
            }
        }

        private void formsPlot1_MouseMove(object sender, MouseEventArgs e)
        {
            ScottPlot.Pixel pixel = new ScottPlot.Pixel(e.X, e.Y);
            ScottPlot.Coordinates coordinates = formsPlot1.Plot.GetCoordinates(pixel);

            this.Text = $"V = {coordinates.X:F2}; L = {coordinates.Y:F2}";
        }
    }
    public class MarkerData
    {
        public string MarkerName;
        public double MarkerV;
        public double MarkerL;
        public MarkerData(string markerName, double markerV, double markerL)
        {
            MarkerName = markerName;
            MarkerV = markerV;
            MarkerL = markerL;
        }
    }
}