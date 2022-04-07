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

namespace TimeReport
{
    public partial class Form1 : Form
    {
        private string _connectionString = @"Server=DESKTOP-2VU5GL9\SQLEXPRESS;Initial Catalog=TimeReport;Integrated Security=true;";
        public Form1()
        {
            InitializeComponent();
            
            EmployeesComboBox.DataSource = LoadComboBox();
            EmployeesComboBox.ValueMember = "EmployeeID";
            EmployeesComboBox.DisplayMember = "FullName";

            ProjectComboBox.DataSource = LoadProjectList();
            ProjectComboBox.ValueMember = "ProjectID";
            ProjectComboBox.DisplayMember = "ProjectName";

            WeekComboBox.SelectedIndex = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter1.Fill(this.timeReportDataSet1.Employee);
        }

        public List<Employee> LoadComboBox() // Hämtar alla anställda från databasen och lägger in dessa i Employee-comboboxen.
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT * FROM Employee";

                        SqlDataReader dr = sqlCommand.ExecuteReader();

                        while (dr.Read())
                        {
                            Employee emp = new Employee(dr["EmployeeID"].ToString(), dr["FirstName"].ToString(), dr["LastName"].ToString());
                            employees.Add(emp);
                        }
                    }
                }
            }
            catch { MessageBox.Show("Something went wrong, please try again."); }
            return employees;
        }
        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetTimeReport(object sender, EventArgs e) // Hämtar alla tidrapporter från databasen.
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string queryString = "Select Timereports.Week , Timereports.Hours, Projects.ProjectName " +
                                     "FROM Timereports " +
                                     "left outer join Employee on Employee.EmployeeID = Timereports.EmployeeID " +
                                     "left outer join Projects on Projects.ProjectID = Timereports.ProjectID " +
                                     $"where Timereports.EmployeeID = {EmployeesComboBox.SelectedValue}";

                SqlDataAdapter da = new SqlDataAdapter(queryString, connection);

                DataSet ds = new DataSet();
                da.Fill(ds, "Timereports");

                if (ds != null)
                {
                    listBox1.Items.Clear();
                    foreach (DataRow row in ds.Tables["Timereports"].Rows)
                    {
                        listBox1.Items.Add("Week: " + (int)row[0] + "\tHours: " + (int)row[1] + "\t\tProject: " + (string)row[2]);
                    }
                }
            }
            
        }
        public List<Projects> LoadProjectList()
        {
            List<Projects> projects = new List<Projects>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT * FROM Projects";

                        SqlDataReader dr = sqlCommand.ExecuteReader();

                        while (dr.Read())
                        {
                            Projects project = new Projects(dr["ProjectID"].ToString(), dr["ProjectName"].ToString());
                            projects.Add(project);
                        }
                    }
                } 
            }
            catch { MessageBox.Show("Something went wrong, please try again."); }
            return projects;
} // Hämtar alla projekt från databasen och lägger in dessa i Project-comboboxen.

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveTimeReportToDB(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    using (var cmd = new SqlCommand("INSERT INTO Timereports (EmployeeID, Hours, Week, ProjectID) VALUES (@EmployeeID,@Hours,@Week,@ProjectID)"))
                    {
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@EmployeeID", EmployeesComboBox.GetItemText(EmployeesComboBox.SelectedValue));
                        cmd.Parameters.AddWithValue("@Hours", HoursInput.Text);
                        cmd.Parameters.AddWithValue("@Week", WeekComboBox.Text);
                        cmd.Parameters.AddWithValue("@ProjectID", ProjectComboBox.GetItemText(ProjectComboBox.SelectedValue));

                        connection.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Timereport successfully reported.");
                        }
                        else
                        {
                            MessageBox.Show("Insert failed");
                        }
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show("Error during insert: " + d.Message);
                }
            }
        }
    }
}
