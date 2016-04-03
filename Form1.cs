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
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Doctors_btn_Click(object sender, EventArgs e)
        {
            Doctors doc = new Doctors();
            doc.Show();
        }

        private void Patients_btn_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Page_Enginner eng = new Page_Enginner();
             eng.Show();
        }

        }

            
    }

