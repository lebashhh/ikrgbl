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
    public partial class GoodsForm: Form
    {
        public GoodsForm(Workers user)
        {
            InitializeComponent();
            _currentUser = user;
        }
        private Workers _currentUser;
        private void GoodsForm_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var goods = db.Goods
                    .Select(g => new
                    {
                        g.ID,
                        g.Name,
                        g.Price,
                        g.Type,
                        g.Description
                    })
                    .ToList();

                dataGridView1.DataSource = goods;
            }

            ConfigureGrid();
        }
        private void ConfigureGrid()
        {
            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["Name"].HeaderText = "Name";

            if (dataGridView1.Columns.Contains("Image"))
                dataGridView1.Columns["Image"].Visible = false;

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
