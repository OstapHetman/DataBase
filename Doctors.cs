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
    public partial class Doctors : Form
    {
        HospitalEntities d;

        public Doctors()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        private void dOCTORS_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORS_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSetNEW.DOCTORS_1". При необходимости она может быть перемещена или удалена.
            this.dOCTORS_1TableAdapter1.Fill(this.hospitalDataSetNEW.DOCTORS_1);
            d = new HospitalEntities();
            dOCTORS_1BindingSource.DataSource = d.DOCTORS_1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.DOCTORS_1". При необходимости она может быть перемещена или удалена.
            this.dOCTORS_1TableAdapter.Fill(this.hospitalDataSet.DOCTORS_1);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dOCTORS_1TableAdapter.FillBy(this.hospitalDataSet.DOCTORS_1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dOCTORS_1TableAdapter.FillBy1(this.hospitalDataSet.DOCTORS_1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dOCTORS_1TableAdapter.FillBy2(this.hospitalDataSet.DOCTORS_1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            DataTable dtaa = new DataTable();
            SqlDataAdapter SDAA = new SqlDataAdapter("SELECT * FROM DOCTORS_1 where ID = " + textBox_ID.Text, conn);
            SDAA.Fill(dtaa);
            dOCTORS_1DataGridView.DataSource = dtaa;
        }

        private void doctorsSearchToolStripButton_Click(object sender, EventArgs e)
        {
          //  try
           // {
           //     this.dOCTORS_1TableAdapter.DoctorsSearch(this.hospitalDataSet.DOCTORS_1, lastNameToolStripTextBox.Text);
           // }
           // catch (System.Exception ex)
           // {
           //     System.Windows.Forms.MessageBox.Show(ex.Message);
           // }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dOCTORS_1BindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.CommandText="insert into DOCTORS_1(ID,FirstName,LastName,HospitalID,Login,Password) values('" + iDTextBox.Text + "', '" + firstNameTextBox.Text + "','" + lastnameTextBox.Text + "','" + hospitalIDTextBox.Text + "','" + loginTextBox.Text + "','" + passwordTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successful");
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dOCTORS_1BindingSource.RemoveCurrent();
        }

                
    }
}
