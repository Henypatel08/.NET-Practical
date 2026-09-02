using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p_5
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //check wether emp Name is Availabel in cookies
                if (Request.Cookies["EmployeeName"] != null)
                {
                    empName.Text = Request.Cookies["EmployeeName"].Value;
                    CheckBox1.Checked = true;
                }

                //Get Selected Leave Date From The Previous Web Page
                if (Session["LeaveDate"] != null)
                {
                    DateTime dt = (DateTime)Session["LeaveDate"];
                    txtFromDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtFromDate.Text = "No Date Selected.....";
                }
            }
        }

        // Calculate number of leave days
        protected void DateChanged(object sender, EventArgs e)
        {
            DateTime fromDate;
            DateTime toDate;

            if (DateTime.TryParse(txtFromDate.Text, out fromDate) &&
                DateTime.TryParse(txtToDate.Text, out toDate))
            {
                if (toDate >= fromDate)
                {
                    lblDays.Text = ((toDate - fromDate).Days + 1).ToString();
                }
                else
                {
                    lblDays.Text = "0";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeID.Text;
            string employeeName = empName.Text;
            string department = ddlDepartment.SelectedValue;
            string fromDate = txtFromDate.Text;
            string toDate = txtToDate.Text;
            string days = lblDays.Text;
            string leaveType = DropDownList1.SelectedValue;
            string reason = TextBox1.Text;
            string contact = txtContact.Text;

            // store employee name in session
            Session["EmployeeName"] = employeeName;

            // store Leave information in Session
            Session["EmployeeID"] = employeeID;
            Session["Department"] = department;
            Session["FromDate"] = fromDate;
            Session["ToDate"] = toDate;
            Session["LeaveDays"] = days;
            Session["LeaveType"] = leaveType;
            Session["Reason"] = reason;
            Session["Contact"] = contact;

            // create cookies if Checkbox is Selected
            if (CheckBox1.Checked)
            {
                Response.Cookies["EmployeeName"].Value = employeeName;

                // Cookies will be expire in 7 Day
                Response.Cookies["EmployeeName"].Expires = DateTime.Now.AddDays(7);

                lblMsg.Text = "Leave Application Submitted Successfully" +
                    "<br/>Employee ID : " + employeeID +
                    "<br/>Employee Name : " + employeeName +
                    "<br/>Department : " + department +
                    "<br/>From Date : " + fromDate +
                    "<br/>To Date : " + toDate +
                    "<br/>Number of Days : " + days +
                    "<br/>Leave Type : " + leaveType +
                    "<br/>Reason : " + reason +
                    "<br/>Contact Number : " + contact;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = "";
            empName.Text = "";
            ddlDepartment.SelectedIndex = 0;
            txtFromDate.Text = "";
            txtToDate.Text = "";
            lblDays.Text = "0";
            DropDownList1.SelectedIndex = 0;
            TextBox1.Text = "";
            txtContact.Text = "";
            CheckBox1.Checked = false;
            chkConfirm.Checked = false;
            lblMsg.Text = "";
        }
    }
}