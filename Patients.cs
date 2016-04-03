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
    public partial class Patients : Form
    {
        HospitalEntities p;

        public Patients()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSetNEW.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter1.Fill(this.hospitalDataSetNEW.Patient);
            p = new HospitalEntities();
            patientBindingSource.DataSource = p.Patient;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            DataTable dta = new DataTable();
            SqlDataAdapter SD = new SqlDataAdapter("SELECT * FROM Patient where SSN = " + textBox_SSN.Text, conn);
            SD.Fill(dta);
            patientDataGridView.DataSource = dta;

        }
        //кнопка додати
        private void button2_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
        }
        //кнопка зберегти
        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.CommandText = "insert into Patient(SSN,FirstName,LastName,DoctorsID) values('" + sSNTextBox.Text + "', '" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + docrotsIDTextBox.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successful");
            cn.Close();
        
        }
        //кнопка видалити
        private void button4_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.RemoveCurrent();
        }
    }
}
