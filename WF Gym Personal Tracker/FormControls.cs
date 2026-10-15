using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker
{
    public static class FormControls
    {
        public static int currentWorkoutIndex = 0;

        public static List<string> noProgressQuotes = new List<string>();
        public static List<string> quarterProgressQuotes = new List<string>();
        public static List<string> halfProgressQuotes = new List<string>();
        public static List<string> fullProgressQuotes = new List<string>();

        static FormControls()
        {
            noProgressQuotes.Add("Let's get started!");
            noProgressQuotes.Add("Don't be lazy!");
            noProgressQuotes.Add("Rest is for the weak");

            quarterProgressQuotes.Add("Keep going!");
            quarterProgressQuotes.Add("You can do better!");

            halfProgressQuotes.Add("So close!");
            halfProgressQuotes.Add("More than half way!");

            fullProgressQuotes.Add("Well done!");
            fullProgressQuotes.Add("You did it!");
        }

        public static void OpenNewForm(Form parent, Form child)
        {
            // allows new form to resize
            child.AutoSize = false;
            child.FormBorderStyle = FormBorderStyle.Sizable;
            child.MaximizeBox = true;

            // 
            child.StartPosition = FormStartPosition.Manual;
            child.Location = parent.Location;

            // preservve window size
            child.Size = parent.Size;

            if (parent.WindowState == FormWindowState.Maximized)
            {
                child.WindowState = FormWindowState.Maximized;
            }
            else
            {
                child.WindowState = FormWindowState.Normal;
            }


            child.Show();
            parent.Hide();
            /*parent.Close();*/
        }

        public static int ReturnTextBoxInt(TextBox tb)
        {
            try
            {
                int val = Convert.ToInt32(tb.Text);
                return val;
            }
            catch (Exception ex)
            {
                /*MessageBox.Show("Invalid Input!");*/
            }
            return -1;
        }

        public static double ReturnTextBoxDoub(TextBox tb)
        {
            try
            {
                double val = Convert.ToDouble(tb.Text);
                return val;
            }
            catch (Exception ex)
            {
                /*MessageBox.Show("Invalid Input!");*/
            }
            return -1;
        }

        public static DateOnly GetTodaysDate()
        {
            return DateOnly.FromDateTime(DateTime.Now);
        }

        public static string GetRandomQuote(ProgressBar pb)
        {
            double percentage = (double)pb.Value / (double)pb.Maximum;
            Random rand = new Random();
            if (percentage <= 0)
            {
                return noProgressQuotes[rand.Next(0, noProgressQuotes.Count)];
            }
            else if (percentage <= 0.5)
            {
                return quarterProgressQuotes[rand.Next(0, quarterProgressQuotes.Count)];
            }
            else if (percentage < 1)
            {
                return halfProgressQuotes[rand.Next(0, halfProgressQuotes.Count)];
            }
            else if (percentage >= 1)
            {
                return fullProgressQuotes[rand.Next(0, fullProgressQuotes.Count)];
            }

            return "How did we get here?";
        }
    }
}
