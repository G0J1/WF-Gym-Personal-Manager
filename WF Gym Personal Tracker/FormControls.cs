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


        public static void OpenNewForm(Form parent, Form child)
        {
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
    }
}
