﻿using DellLibrary.BL;
using System;
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
    public partial class SalesPersonUI : Form
    {
        EmployeeBL SalesPerson = null;
        public SalesPersonUI(EmployeeBL emp)
        {
            InitializeComponent();
            SalesPerson = emp;
        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
