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
namespace El_Market
{
    public partial class Staff_Form : Form
    {
        public Staff_Form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\source\repos\El-Market\El-Market\El-MarketDB1.mdf;Integrated Security=True");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //SqlCommand cmd = new SqlCommand();
                //string query = "insert into StaffTbl values(" + txtStaffID.Text + ",'" + txtStaffName.Text + "'," + txtStaffAge.Text + "," + txtStaffPhone.Text + "," + txtStaffAddress.Text + "," + txtStaffSalary.Text + "," + txtStaffUsername.Text + "," + ",'" + txtStaffPassword.Text + "')";

                SqlCommand cmd = new SqlCommand("insert into StaffTbl values('" + txtStaffID.Text + "','" + txtStaffName.Text + "','" + txtStaffAge.Text + "','" + txtStaffPhone.Text + "','" + txtStaffAddress.Text + "','" + txtStaffSalary.Text + "','" + txtStaffUsername.Text + "','" + txtStaffPassword.Text + "')", con);
                //cmd.CommandText = @"INSERT INTO StaffTbl VALUES(@ID, @Name, @Age, @Phone, @Address, @Salary, @Username, @Password)";
                //cmd.Parameters.AddWithValue("@ID", txtStaffID.Text);
                //cmd.Parameters.AddWithValue("@Name", txtStaffName.Text);
                //cmd.Parameters.AddWithValue("@Age", txtStaffAge.Text);
                //cmd.Parameters.AddWithValue("@Phone", txtStaffPhone.Text);
                //cmd.Parameters.AddWithValue("@Address", txtStaffAddress.Text);
                //cmd.Parameters.AddWithValue("@Salary", txtStaffSalary.Text);
                //cmd.Parameters.AddWithValue("@Username", txtStaffUsername.Text);
                //cmd.Parameters.AddWithValue("@Password", txtStaffPassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Added Successfully");
                con.Close();
                populate();
                txtStaffID.Text = "";
                txtStaffName.Text = "";
                txtStaffAge.Text = "";
                txtStaffPhone.Text = "";
                txtStaffAddress.Text = "";
                txtStaffSalary.Text = "";
                txtStaffUsername.Text =
                txtStaffPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStaffID.Text == "" || txtStaffName.Text == "" || txtStaffAge.Text == "" || txtStaffPhone.Text == "" || txtStaffAddress.Text == "" || txtStaffSalary.Text == "" || txtStaffUsername.Text == "" || txtStaffPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    //string query = "update StaffTbl set StaffName='" + txtStaffName.Text + "',StaffAge=" + txtStaffAge.Text + ",StaffPhone=" + txtStaffPhone.Text + ",StaffAddress=" + txtStaffAddress.Text + ",StaffSalary="+ txtStaffSalary.Text + ",StaffUsername=" + txtStaffUsername.Text + ",StaffPassword=" + txtStaffPassword.Text + " where StaffId=" + txtStaffID.Text + "; ";
                    string query = "UPDATE StaffTbl SET StaffName='"+ txtStaffName.Text + "',StaffAge='"+txtStaffAge.Text+"',StaffPhone='"+txtStaffPhone.Text+"',StaffAddress='"+txtStaffAddress.Text+"' ,StaffSalary='"+txtStaffSalary.Text+"' ,StaffUsername='" + txtStaffUsername.Text + "' ,StaffPassword='" + txtStaffPassword.Text + "' WHERE StaffId = " + txtStaffID.Text;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Updated");
                    con.Close();
                    populate();
                    txtStaffID.Text = "";
                    txtStaffName.Text = "";
                    txtStaffAge.Text = "";
                    txtStaffPhone.Text = "";
                    txtStaffAddress.Text = "";
                    txtStaffSalary.Text = "";
                    txtStaffUsername.Text =
                    txtStaffPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStaffID.Text == "")
                {
                    MessageBox.Show("Select the Staff to Delete");
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string query = "delete from StaffTbl where StaffId=" + txtStaffID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Successfully");
                    con.Close();
                    populate();
                    txtStaffID.Text = "";
                    txtStaffName.Text = "";
                    txtStaffAge.Text = "";
                    txtStaffPhone.Text = "";
                    txtStaffAddress.Text = "";
                    txtStaffSalary.Text = "";
                    txtStaffUsername.Text = "";
                    txtStaffPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string query = "select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Staff_Form_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Item_Form Prod = new Item_Form();
            Prod.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Category_Form Cat = new Category_Form();
            Cat.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling_Form sell = new Selling_Form();
            sell.Show();
            this.Hide();
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStaffID.Text = StaffDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtStaffName.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtStaffAge.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtStaffPhone.Text = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtStaffAddress.Text = StaffDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtStaffSalary.Text = StaffDGV.SelectedRows[0].Cells[5].Value.ToString();
            txtStaffUsername.Text = StaffDGV.SelectedRows[0].Cells[6].Value.ToString();
            txtStaffPassword.Text = StaffDGV.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
