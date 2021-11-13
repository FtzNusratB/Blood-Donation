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

namespace BloodDonation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer3_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer3_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details d = new Details();
            d.Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VBTM3QE;Initial Catalog=Blood;Integrated Security=True");
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donar_Center d = new Donar_Center();
            d.Show();
        }
    }
}
