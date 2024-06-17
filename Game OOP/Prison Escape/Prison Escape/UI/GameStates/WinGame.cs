using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Escape.UI.GameStates
{
    public partial class WinGame : Form
    {
        public WinGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            Level1 level1 = new Level1();
            level1.Show();
        }
    }
}
