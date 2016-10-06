using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentApp
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = Convert.ToInt32(regNoTextBox.Text);
            aStudent.FirstName = firstNameTextBox.Text;
            aStudent.LastName = lastNameTextBox.Text;

            if (Session["students"] == null)
            {
                List<Student> studentsList = new List<Student>();

                studentsList.Add(aStudent);
                Session["students"] = studentsList;
            }
            else
            {
                List<Student> studentsList = (List<Student>)Session["students"];

                studentsList.Add(aStudent);
                Session["students"] = studentsList;
            }

            ClearFields();
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            List<Student> studentsList = (List<Student>)Session["students"];
            outputLabel.Text = "Registration No" + "&nbsp" + "Full Name"+"<br>";

            foreach (Student allStudent in studentsList)
            {
                outputLabel.Text += allStudent.RegNo + "&nbsp&nbsp&nbsp&nbsp" + allStudent.GetFullName(allStudent.FirstName, allStudent.LastName)+"<br>";
            }
        }

        public void ClearFields()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }
    }
}