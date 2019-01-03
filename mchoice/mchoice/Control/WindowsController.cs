using mchoice.View;
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
            parent.Hide();
            loginform login = new loginform();
            login.Show();
            login.getParent(parent);
        }

        public static void showAddQuizWindow(Form1 parent)
        {
            parent.Hide();
            AddQuizForm add = new AddQuizForm();
            add.Show();
            add.getParent(parent);
            
        }

        public static void checkLogin(loginform loginform, Form1 parent)
        {
            string username = loginform.Username;
            string password = loginform.Password;

            DBConnect.Initialize();
            DBConnect db = new DBConnect();

            bool user = db.checkIfUserExists(username, password);

            if (user)
            {
                parent.userLoggedIn(username);
                parent.Show();
                DBConnect.CloseConnection();
                loginform.Close();
            }
            else
            {
                loginform.changeBorderColor();
            }
        }


    }
}
