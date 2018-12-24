using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mchoice.Control
{
    public class WindowsController
    {
        public static void showLogInWindow(Form1 parent)
        {
            loginform login = new loginform();
            login.Show();
            login.getParent(parent);
        }


    }
}
