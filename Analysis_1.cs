using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ButtonClass
{
    public partial class Analysis_1 : Form
    {
        HospitalEntities anal;

        public Analysis_1()
        {
            InitializeComponent();
        }

   

        private void Analysis_1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSetNEW.Analysis". При необходимости она может быть перемещена или удалена.
            this.analysisTableAdapter1.Fill(this.hospitalDataSetNEW.Analysis);
            anal = new HospitalEntities();
            analysisBindingSource.DataSource = anal.Analysis;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.analysisBindingSource1.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysisBindingSource1.EndEdit();
            this.analysisTableAdapter.Update(this.hospitalDataSet.Analysis);
            MessageBox.Show("Update successful");
                    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.analysisBindingSource1.RemoveCurrent();
        }

        private void analysisDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Analysis where ID = " + textBox1.Text, conn);
            SDA.Fill(dt);
            analysisDataGridView.DataSource = dt;
        }

        private void analysisDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        

        
    }
}
