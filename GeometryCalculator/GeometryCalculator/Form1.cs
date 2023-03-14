namespace GeometryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate area of square:
            int SquareEdgeLength = Convert.ToInt16(textBoxSquareEdge.Text);
            int SquareArea = Convert.ToInt16(Math.Pow(SquareEdgeLength, 2));
            labelSquareArea.Text = SquareArea.ToString();
            // Calculate area of rectangle:
            int RectangleLongEdge = Convert.ToInt16(textBoxRectangleLongEdge.Text);
            int RectangleShortEdge = Convert.ToInt16(textBoxRectangleShortEdge.Text);
            int RectangleArea = RectangleLongEdge * RectangleShortEdge;
            labelRectangleArea.Text = RectangleArea.ToString();
            // Calculate area of circle:
            int CircleRadius = Convert.ToInt16(textBoxCircleRadius.Text);
            int CircleArea = (int)Math.PI * ((int)Math.Pow(CircleRadius, 2));
            labelCircleArea.Text = CircleArea.ToString();
        }
    }
}