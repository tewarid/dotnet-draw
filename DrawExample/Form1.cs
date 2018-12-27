using System.Windows.Forms;

namespace DrawExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("{0}, {1}", e.X, e.Y); 
        }
    }
}
