using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Xml.Linq;


namespace database2
{
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            con = new SqlConnection(str);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into student values(@name,@city,@perc)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtnames.Text);
                cmd.Parameters.AddWithValue("city",txtcity.Text);
                cmd.Parameters.AddWithValue("@perc", Convert.ToInt32(txtpercentages.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show(" Inserted ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update student set names=@name,city=@city,percentages=@perc where rollno=@roll";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtnames.Text);
                cmd.Parameters.AddWithValue("@city", txtcity.Text);
                cmd.Parameters.AddWithValue("@perc", Convert.ToInt32(txtpercentages.Text));
                cmd.Parameters.AddWithValue("@roll", Convert.ToInt32(txtrollno.Text));

                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show(" Updated ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from student where rollno=@roll";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll", Convert.ToInt32(txtrollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student where rollno=@roll";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll", Convert.ToInt32(txtrollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtnames.Text = dr["names"].ToString();
                        txtcity.Text = dr["city"].ToString();
                        txtpercentages.Text = dr["percentages"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show(" Not Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    data.DataSource = table;
                }
                else
                {
                    MessageBox.Show(" Not Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
