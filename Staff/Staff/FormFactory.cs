using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff
{
    public static class FormFactory
    {
        public static Form CreateAddForm(Form1 parentForm)
        {
            return new AddForm(parentForm);
        }

        public static Form CreateStaffDetailsForm(int staffID, string name, string role, string username, string password)
        {
            return new StaffDetailsForm(staffID, name, role, username, password);
        }
    }

}
