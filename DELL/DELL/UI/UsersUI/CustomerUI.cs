﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELL.UI.UsersUI
{
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
