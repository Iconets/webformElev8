using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace webformElev8
{
    public partial class RegistrationFroms : System.Web.UI.Page
    {
        DataClass dataClass = new DataClass();
        EmployeesInfo employeesInfo = new EmployeesInfo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            employeesInfo.Surname = txtSurname.Text;
            employeesInfo.OtherNames = txtOtherNames.Text;
            employeesInfo.Gender = ddpGender.Text;
            employeesInfo.MobileNo = txtMobileNo.Text;
            employeesInfo.EmailAddress = txtemail.Text;
            employeesInfo.Address = txtAddress.Text;
            employeesInfo.DateEmployed = Convert.ToDateTime(dtEmployed.SelectedDate.ToString());
            employeesInfo.DateofBirth = Convert.ToDateTime(dtBirth.SelectedDate.ToString());
            int result = dataClass.CreateEmployeeRecord(employeesInfo);
            if (result>0)
            {
                lblDisplay.Text="Record Added Successfully";
            }
            else
            { 
                lblDisplay.Text = "Error adding record";
            }
        }
        protected void bttn_read (object sender, EventArgs e)
        {
            dgView.DataSource = dataClass.ReadEmployeeRecord();
        }

       protected void bttn_update (object sender, EventArgs e)
        {
           // employeesInfo.TrId = Convert.ToInt32(lblTrId.Text);
            employeesInfo.Surname = txtSurname.Text;
            employeesInfo.OtherNames = txtOtherNames.Text;
            employeesInfo.Gender = ddpGender.Text;
            employeesInfo.MobileNo = txtMobileNo.Text;
            employeesInfo.EmailAddress = txtemail.Text;
            employeesInfo.Address = txtAddress.Text;
            employeesInfo.DateEmployed = Convert.ToDateTime(dtEmployed.SelectedDate.ToString());
            employeesInfo.DateofBirth = Convert.ToDateTime(dtBirth.SelectedDate.ToString());

           int result = dataClass.UpdateEmployeeRecord(employeesInfo);
            if(result>0)
            {
                lblDisplay.Text = "Record updated Successfully";
            }
            else
            {
                lblDisplay.Text = "Error updating record";
            }
        }

        
    }
}