using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p_5
{
    public partial class calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void calAcademic(object sender, EventArgs e)
        {
            DateTime selecedDt = Calendar1.SelectedDate;
            LabelSelectDate.Text = "Selected Dated " +
                selecedDt.ToString("dd/MM/yyyy");

            //Store Selected Date in Session
            Session["LeaveDate"] = selecedDt;
        }

        protected void button1_click(object sender, EventArgs e)
        {
            //Leave Apply
            Response.Redirect("Leave.aspx");
        }
    }
}