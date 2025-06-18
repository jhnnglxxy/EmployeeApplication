using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
            keyPressHandler();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
        }

        public void textOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        public void keyPressHandler()
        {
            fname.KeyPress += textOnly;
            lname.KeyPress += textOnly;
            empposition.KeyPress += textOnly;

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeid.Text) ||
                string.IsNullOrWhiteSpace(fname.Text) ||
                string.IsNullOrWhiteSpace(lname.Text) ||
                string.IsNullOrWhiteSpace(empposition.Text))
            {
                MessageBox.Show("Please fill in all the fields >:[");
                return;
            }

            long employeeID = Convert.ToInt64(employeeid.Text.Trim());
            string empIdStr = employeeID.ToString();

            foreach (DataGridViewRow row in empList.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == empIdStr)
                {
                    MessageBox.Show("This Employee ID already exists. Try again.");
                    return;
                }
            }

            Employee employee = new Employee(Convert.ToInt64(employeeid.Text), fname.Text, lname.Text, empposition.Text);

            empList.Rows.Add(employee.employeeId, employee.empFname, employee.empLname, employee.empPosition);

            employeeid.Clear();
            fname.Clear();
            lname.Clear();
            empposition.Clear();

        }
    }
}
