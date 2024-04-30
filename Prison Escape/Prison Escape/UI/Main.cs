using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Escape.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Level1 level1 = new Level1();
            level1.Show();
        }
    }
}
