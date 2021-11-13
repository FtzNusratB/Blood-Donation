using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class AddNewDonor : Form
    {
        // function fn = new function();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VBTM3QE;Initial Catalog=Blood;Integrated Security=True");
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            disp_data();
           /* String qurey = "select max(did) from newDonor";
            DataSet ds = fn.getData(qurey);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text =(count+1).ToString();*/
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            /* if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtAddress.Text != "");
             {
               string dname = txtName.Text;
                 string fname = txtFather.Text;
                 string mname = txtMobile.Text;
                  string dob = txtDOB.Text;
                 string mobile = txtMobile.Text;
                 string gender = txtGender.Text;
                 string email = txtEmail.Text;
                 string bloodgroup = txtBloodGroup.Text;
                 string city = txtCity.Text;
                 string address = txtAddress.Text;

                 string query = "Insert into Table(did,dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values('"+DonorID+"'''"+dname+"'," + fname + "','" + mname + "','" + dob + "','" + mobile + "','" + gender + "','" + email + "','" + bloodgroup + "','" + city + "','" + address + "')";

                // fn.setData(query);



             }



                 MessageBox.Show("Fill all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

             */

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Insert Into Table_1 values( '"+txtID.Text+"','"+txtName.Text+"','"+txtFather.Text+"', '"+txtMother.Text+"' ,'"+txtDOB.Text+"' ,'"+txtMobile.Text+"','"+txtGender.Text+"' ,'"+txtEmail.Text+"' ,'"+txtBloodGroup.Text+"' ,'"+txtCity.Text+"' ,'"+txtAddress.Text+"' ) ";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record Insert Sucessfully.");

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Table_1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           
        }

       /* private void button1_Click(object sender, EventArgs e)
        {


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table_1 where did='" + txtID.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record Deleted Sucessfully.");
        }*/

        private void DonorID_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  Table_1 set did='"+txtID.Text+"' where dname='" + txtName.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record Deleted Sucessfully.");*/

            con.Open();
            string query = "Update Table_1 Set dname='" + txtName.Text + "', fname='"+txtFather.Text+"',mname='"+txtMother.Text+"',dob='"+txtDOB.Text+"',mobile='"+txtMobile.Text+"',gender='"+txtGender.Text+"', email='"+txtEmail.Text+"',bloodgroup='"+txtBloodGroup.Text+"', city='"+txtCity.Text+"',address='"+txtAddress.Text+"' WHERE did='"+txtID.Text+"'";
            SqlDataAdapter Sda = new SqlDataAdapter(query, con);
            Sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully");

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtFather.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtMother.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtDOB.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtMobile.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtGender.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtBloodGroup.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT *FROM Table_1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtDOB.Clear();
            txtMobile.Clear();
            txtGender.Clear();
            txtEmail.Clear();
            txtBloodGroup.Clear();
            txtCity.Clear();
            txtAddress.Clear();
            MessageBox.Show("Reset Sucessfully");

        }

        private void txtBloodGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
        }
    }
}
