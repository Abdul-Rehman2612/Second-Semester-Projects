using Prison_Escape.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Escape
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 level1 = new Level1();
            level1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions instructions = new Instructions();
            instructions.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
