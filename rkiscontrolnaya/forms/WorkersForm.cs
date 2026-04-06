using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rkiscontrolnaya.forms.add_dell_change;
using rkiscontrolnaya.Models;

namespace rkiscontrolnaya.forms
{
    public partial class WorkersForm: Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (var db = new Model1())
            {
                var workers = db.Workers
                    .Select(w => new
                    {
                        w.ID,
                        w.Login,
                        w.First_Name,
                        w.Second_Name,
                        w.Middle_Name,
                        w.Role
                    })
                    .ToList();

                dataGridView1.DataSource = workers;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditWorkerForm form = new AddEditWorkerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int workerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            EditWorkersForm form = new EditWorkersForm(workerId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите сотрудника!");
                return;
            }

            int workerId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["ID"].Value
            );

            var confirm = MessageBox.Show(
                "Вы действительно хотите удалить сотрудника?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (var db = new Model1())
            {
                var worker = db.Workers.FirstOrDefault(w => w.ID == workerId);

                if (worker != null)
                {
                    db.Workers.Remove(worker);
                    db.SaveChanges();
                }
            }

            LoadData();

            MessageBox.Show("Сотрудник удалён.");
        }
    }
}
