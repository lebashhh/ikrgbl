using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ikrgbl.forms;
using ikrgbl.Models;

namespace ikrgbl
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var user = db.Workers
                    .FirstOrDefault(x => x.Login == txtLogin.Text
                                      && x.Password == txtPassword.Text);

                if (user != null)
                {
                    MenuForm menu = new MenuForm(user);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
