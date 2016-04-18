using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.LINQ
{
    class Employee
    {
        private int employeeID;
        private string fullName;
        private string lastName;
        private double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        //public Employee()
        //{
        //    employeeID = 0;
        //    fullName = "";
        //    lastName = "";
        //    salary = 0.0;
        //}
        //public Employee(int empIDValue, string fullNameVal, string lastNameVal)
        //{
        //    employeeID = empIDValue;
        //    fullName = fullNameVal;
        //    lastName = lastNameVal;
        //    salary = 0.0;
        //}
        public Employee(int empIDValue, string fullNameVal, string lastNameVal, double salaryValue)
        {
            employeeID = empIDValue;
            fullName = fullNameVal;
            lastName = lastNameVal;
            salary = salaryValue;
        }
        public int EmployeeIDNum
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;

            }
        }
        public int Getinfo
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }

        }
        public string employeeInformationToString()
        {
            // employeeID = Convert.ToInt32(this.textBox1.Text);
            return (Convert.ToString(employeeID) + " " + fullName + " " + lastName + " " + Convert.ToString(salary));
        }
    }
    public partial class MinMaxMultipleValue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee[] employee = new Employee[10];
            employee[0] = new Employee(17433, "Adrian", "Smith", 8000.01);
            employee[1] = new Employee(17433, "Adrian", "Smith", 8000.01);
            employee[2] = new Employee(17434, "Stephen", "Rad", 9000.00);
            employee[3] = new Employee(17435, "Jesse", "Harris", 8000.01);
            employee[4] = new Employee(17436, "jonatan", "Morris", 9500.00);
            employee[5] = new Employee(17437, "Morgen", "Freeman", 12000.00);
            employee[6] = new Employee(17438, "Leory", "Gomez", 10200.00);
            employee[7] = new Employee(17439, "Michael", "Brown", 9000.00);
            employee[8] = new Employee(17440, "Andrew", "White", 35000.00);
            employee[9] = new Employee(17441, "Maria", "Carson", 12000.00);
            //employee[10] = new Employee(17442, "Mark", "Jonson", 17000.00);
           // var itemsMax = items.Where(x => x.Height == items.Max(y => y.Height));
            var minEmpSalarylist = employee.Where(x => x.Salary == employee.Min(y => y.Salary)).ToList();

        }
    }
}