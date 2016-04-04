using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Pacient : Form
    {
        public Pacient()
        {
            InitializeComponent();
        }

        private void analysisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Pacient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Analysis". При необходимости она может быть перемещена или удалена.
            this.analysisTableAdapter.Fill(this.hospitalDataSet.Analysis);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=AND-ПК\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Analysis where Patient_SSN = " + textBox1.Text, conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
