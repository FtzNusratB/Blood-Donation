﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodDonation
{
    public partial class Update : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VBTM3QE;Initial Catalog=Blood;Integrated Security=True");
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT *FROM Table_1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Update Table_1 Set dname='" + txtName.Text + "', fname='" + txtFather.Text + "',mname='" + txtMother.Text + "',dob='" + txtDOB.Text + "',mobile='" + txtMobile.Text + "',gender='" + txtGender.Text + "', email='" + txtEmail.Text + "',bloodgroup='" + txtBloodGroup.Text + "', city='" + txtCity.Text + "',address='" + txtAddress.Text + "' WHERE did='" + txtID.Text + "'";
            SqlDataAdapter Sda = new SqlDataAdapter(query, con);
            Sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
