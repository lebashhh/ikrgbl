namespace ikrgbl.forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.button1 = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnSold = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoods.Location = new System.Drawing.Point(314, 204);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(75, 23);
            this.btnGoods.TabIndex = 1;
            this.btnGoods.Text = "Товары";
            this.btnGoods.UseVisualStyleBackColor = true;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorkers.Location = new System.Drawing.Point(366, 285);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(75, 23);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "Сотрудники";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnSold
            // 
            this.btnSold.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSold.Location = new System.Drawing.Point(427, 204);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(75, 23);
            this.btnSold.TabIndex = 3;
            this.btnSold.Text = "Проданный товар";
            this.btnSold.UseVisualStyleBackColor = true;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 91);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(347, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Меню";
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.Location = new System.Drawing.Point(91, 135);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(68, 33);
            this.lblFIO.TabIndex = 1;
            this.lblFIO.Text = "Фио";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.Location = new System.Drawing.Point(91, 204);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(71, 33);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Роль";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.btnGoods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblRole;
    }
}