using System;
using System.Web.UI;
namespace PRECTICAL4
{
    public partial class EVENTREGISTRATION : System.Web.UI.Page
    {
        protected void CustomValidatorDOB_ServerValidate(
        object source,
        System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
        protected void submitbtn(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;
            if (!CheckBox5.Checked)
                return;
            string department = "";
            string gender = "";
            string skills = "";
            string dob = "";
            if (RadioButton1.Checked)
                department = "COMPUTER";
            else if (RadioButton2.Checked)
                department = "MECHANICAL";
            else if (RadioButton3.Checked)
                department = "ICT";
            else if (RadioButton4.Checked)
                department = "CHEMICAL";
            else if (RadioButton5.Checked)
                department = "CIVIL";
            if (RadioButton6.Checked)
                gender = "MALE";
            else if (RadioButton7.Checked)
                gender = "FEMALE";
            if (CheckBox1.Checked)
                skills += "C ";
            if (CheckBox2.Checked)
                skills += "C# ";
            if (CheckBox3.Checked)
                skills += "C++ ";
            if (CheckBox4.Checked)
                skills += "Java ";
            if (Calendar1.SelectedDate != DateTime.MinValue)
                dob = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Label11.Text =
            "<h2> REGISTRATION SUCESSFULLY ..!!</h2>" +
            "Full Name : " + TextBox1.Text + "<br/>" +
            "Email : " + TextBox2.Text + "<br/>" +
            "Contact No : " + TextBox3.Text + "<br/>" +
            "DOB : " + dob + "<br/>" +
            "College Name : " + TextBox4.Text + "<br/>" +
            "Department : " + department + "<br/>" +
            "Event : " + DropDownList1.SelectedItem.Text + "<br/>" +
            "Gender : " + gender + "<br/>" +
            "Skills : " + skills + "<br/>" +
            "Address : " + TextBox5.Text + "<br/>" +
            "Terms : " + (CheckBox5.Checked ? "Accepted" : "Not Accepted");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode
            = UnobtrusiveValidationMode.None;
        }
        protected void clearbtn(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            RadioButton5.Checked = false;
            RadioButton6.Checked = false;
            RadioButton7.Checked = false;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            DropDownList1.SelectedIndex = 0;
            Label11.Text = "";
        }
    }
}