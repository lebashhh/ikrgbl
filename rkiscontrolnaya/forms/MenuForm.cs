using ikrgbl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikrgbl.forms
{
    public partial class MenuForm: Form
    {
        private Workers _currentUser;
        public MenuForm(Workers user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblFIO.Text = _currentUser.Second_Name + " " +
                  _currentUser.First_Name + " " +
                  _currentUser.Middle_Name;

            lblRole.Text = _currentUser.Role;
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            GoodsForm goods = new GoodsForm(_currentUser);
            goods.Show();
            this.Hide();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            SoldItemForm sold = new SoldItemForm(_currentUser);
            sold.Show();
            this.Hide();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            WorkersForm workers = new WorkersForm();
            workers.Show();
            this.Hide();
        }
    }
}
