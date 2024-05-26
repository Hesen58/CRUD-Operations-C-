using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Length == 0)
                    {
                        isEmpty = true;
                        break;
                    }

                }
            }

            if (isEmpty)
            {
                MessageBox.Show("Please fill all Text Boxes !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-H4AKNPR\\MSSQLSERVER_2019;Initial Catalog=CrudApp;User ID=sa;Password=SQLserver2019;TrustServerCertificate=True");
                con.Open();
                string sql = "insert into crud_app (email,name,username,password) values (@email,@name,@username,@password)";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                sqlCommand.Parameters.AddWithValue("@email", EmailBox.Text);
                sqlCommand.Parameters.AddWithValue("@name", NameBox.Text);
                sqlCommand.Parameters.AddWithValue("@username", UsernameBox.Text);
                sqlCommand.Parameters.AddWithValue("@password", PasswordBox.Text);

                int count = sqlCommand.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Data is added successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error in addition process !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H4AKNPR\\MSSQLSERVER_2019;Initial Catalog=CrudApp;User ID=sa;Password=SQLserver2019;TrustServerCertificate=True");
            con.Open();
            string sql = "select * from crud_app";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H4AKNPR\\MSSQLSERVER_2019;Initial Catalog=CrudApp;User ID=sa;Password=SQLserver2019;TrustServerCertificate=True");
            con.Open();
            string sql = " update crud_app set email=@email , name=@name , username=@username , password=@password where ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@email", EmailBox.Text);
            cmd.Parameters.AddWithValue("@name", NameBox.Text);
            cmd.Parameters.AddWithValue("@username", UsernameBox.Text);
            cmd.Parameters.AddWithValue("@password", PasswordBox.Text);
            cmd.Parameters.AddWithValue("@ID", numericUpDown1.Value);

            int count = cmd.ExecuteNonQuery();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Data is updated succesfully ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in action ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H4AKNPR\\MSSQLSERVER_2019;Initial Catalog=CrudApp;User ID=sa;Password=SQLserver2019;TrustServerCertificate=True");
            con.Open();
            string sql = "delete from crud_app where ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", numericUpDown1.Value);

            int count = cmd.ExecuteNonQuery();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Data is removed succesfully ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error in action ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
