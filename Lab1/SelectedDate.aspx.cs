using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class SelectedDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.DayRender += new DayRenderEventHandler(Calendar1_DayRender);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string strLastName, strFirstName, strFullName, myDate;
            strFirstName = txtfname.Text.Trim();
            strLastName = txtlname.Text.Trim();
            strFullName = strFirstName + " " + strLastName;

            if (this.Calendar1.SelectedDates.Count == 1)
            {
                myDate = "Selected date: " + Calendar1.SelectedDate;
            }
            else
            {
                myDate = "Selected dates: " + Calendar1.SelectedDates[0] + " to " + Calendar1.SelectedDates[Calendar1.SelectedDates.Count - 1];
            }

            lblDisplay.Text = strFullName + "<br/>" + myDate;

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            e.Cell.VerticalAlign = VerticalAlign.Top;

            if (e.Day.DayNumberText == "7")
            {
                e.Cell.BorderColor = System.Drawing.Color.SpringGreen;
                e.Cell.BorderStyle = BorderStyle.Groove;
                e.Cell.Controls.Add(new LiteralControl("<p><i>Second day of class</i></p>"));
            }
        }

    }
}