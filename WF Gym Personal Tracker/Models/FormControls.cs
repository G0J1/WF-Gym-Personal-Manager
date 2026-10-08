using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gym_Personal_Tracker.Models
{
    public static class FormControls
    {
        public static void OpenNewForm(Form parent, Form child)
        {
            child.Show();
            parent.Hide();
        }
    }
}
