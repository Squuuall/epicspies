using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace epicspies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            TimeSpan totalDurationOfAssignment = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
            double totalCost = totalDurationOfAssignment.TotalDays * 500.0;
            if (totalDurationOfAssignment.TotalDays > 21)
            {
                totalCost += 1000.0;
            }
            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", codeNameTextBox.Text, assignmentNameTextBox.Text, totalCost);
            TimeSpan timeBetweenAssignments = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least 2 weeks between assignments.";

                DateTime earliestNewAssignmentDate = Calendar1.SelectedDate.AddDays(14);
                Calendar2.SelectedDate = earliestNewAssignmentDate;
                Calendar2.VisibleDate = earliestNewAssignmentDate;
            }
        }
    }
}