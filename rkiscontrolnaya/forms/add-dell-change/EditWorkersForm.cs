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
    public partial class EditWorkersForm: Form
    {
        private int _workerId;

        public EditWorkersForm(int workerId)
        {
            InitializeComponent();
            _workerId = workerId;
        }

        private void EditWorkerForm_Load(object sender, EventArgs e)
        {

            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Seller");
            cmbRole.Items.Add("Director");

            LoadWorkerData();
        }

        private void LoadWorkerData()
        {
            using (var db = new Model1())
            {
                var worker = db.Workers.FirstOrDefault(w => w.ID == _workerId);

                if (worker == null)
                {
                    MessageBox.Show("Сотрудник не найден!");
                    this.Close();
                    return;
                }

                txtLogin.Text = worker.Login;

                txtPassword.Text = worker.Password;
                txtFirstName.Text = worker.First_Name;
                txtSecondName.Text = worker.Second_Name;
                txtMiddleName.Text = worker.Middle_Name;
                cmbRole.Text = worker.Role;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var worker = db.Workers.FirstOrDefault(w => w.ID == _workerId);

                if (worker == null) return;

                worker.Password = txtPassword.Text;
                worker.First_Name = txtFirstName.Text;
                worker.Second_Name = txtSecondName.Text;
                worker.Middle_Name = txtMiddleName.Text;
                worker.Role = cmbRole.Text;

                db.SaveChanges();
            }

            MessageBox.Show("Сотрудник изменён!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

