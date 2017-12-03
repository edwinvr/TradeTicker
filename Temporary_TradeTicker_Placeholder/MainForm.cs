using System;
using System.Windows.Forms;

namespace Temporary_TradeTicker_Placeholder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.Show();
        }
    }
}
