using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rkiscontrolnaya.Models;

namespace rkiscontrolnaya.forms.add_dell_change
{
    public partial class AddEditWorkerForm: Form
    {
        public AddEditWorkerForm()
        {
            InitializeComponent();
        }
        private void AddEditWorkerForm_Load(object sender, EventArgs e)
        {

            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Seller");
            cmbRole.Items.Add("Director");

            cmbRole.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                MessageBox.Show("Заполните обязательные поля!");
                return;
            }

            using (var db = new Model1())
            {
                Workers worker = new Workers
                {
                    Login = txtLogin.Text,
                    Password = txtPassword.Text,
                    First_Name = txtFirstName.Text,
                    Second_Name = txtSecondName.Text,
                    Middle_Name = txtMiddleName.Text,
                    Role = cmbRole.SelectedItem.ToString()
                };

                db.Workers.Add(worker);
                db.SaveChanges();
            }

            MessageBox.Show("Сотрудник успешно добавлен!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
