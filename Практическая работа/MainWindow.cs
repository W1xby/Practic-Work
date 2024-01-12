using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Практическая_работа
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
