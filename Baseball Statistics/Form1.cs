﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball_Statistics
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            PositionSearch PosSearch = new PositionSearch();
            PosSearch.Show();
        }
    }
}
