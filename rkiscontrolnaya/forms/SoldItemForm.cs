using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ikrgbl.Models;

namespace ikrgbl.forms
{
    public partial class SoldItemForm: Form
    {
        private Workers _currentUser;
        public SoldItemForm(Workers user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void SoldItemForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (var db = new Model1())
            {
                var soldItems = db.Sold_item
                    .Select(s => new
                    {
                        s.ID,
                        s.ID_Good,
                        s.ID_Worker,
                        s.Date_of_sale,
                        s.ID_Outlets
                    })
                    .ToList();

                dataGridView1.DataSource = soldItems;
            }

            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["ID_Good"].HeaderText = "Товар";
            dataGridView1.Columns["ID_Worker"].HeaderText = "Сотрудник";
            dataGridView1.Columns["Date_of_sale"].HeaderText = "Дата продажи";
            dataGridView1.Columns["ID_Outlets"].HeaderText = "Точка";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm(_currentUser);
            menu.Show();
            this.Hide();
        }
    }
}
