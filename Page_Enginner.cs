using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonClass
{
    public partial class Page_Enginner : Form
    {
        public Page_Enginner()
        {
            InitializeComponent();
        }

        private void buttn_analysis_Click(object sender, EventArgs e)
        {
            Analysis_1 an = new Analysis_1();
            an.Show();
        }
    }
}
