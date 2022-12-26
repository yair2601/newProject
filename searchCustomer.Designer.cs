namespace Project
{
    partial class searchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchCustomer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDcheck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.CustomerOrders = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-91, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(264, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter Customer\'s ID";
            // 
            // IDcheck
            // 
            this.IDcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IDcheck.Location = new System.Drawing.Point(376, 131);
            this.IDcheck.Name = "IDcheck";
            this.IDcheck.Size = new System.Drawing.Size(245, 30);
            this.IDcheck.TabIndex = 2;
            this.IDcheck.TextChanged += new System.EventHandler(this.IDcheck_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(311, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "What would you like to do?";
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateCustomer.Location = new System.Drawing.Point(34, 355);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(229, 82);
            this.UpdateCustomer.TabIndex = 4;
            this.UpdateCustomer.Text = "Update Customer\'s info";
            this.UpdateCustomer.UseVisualStyleBackColor = true;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // CustomerOrders
            // 
            this.CustomerOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerOrders.Location = new System.Drawing.Point(317, 355);
            this.CustomerOrders.Name = "CustomerOrders";
            this.CustomerOrders.Size = new System.Drawing.Size(235, 82);
            this.CustomerOrders.TabIndex = 5;
            this.CustomerOrders.Text = "View Customer\'s orders";
            this.CustomerOrders.UseVisualStyleBackColor = true;
            this.CustomerOrders.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenu.Location = new System.Drawing.Point(598, 355);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(229, 82);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(446, 196);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(105, 31);
            this.Check.TabIndex = 7;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // searchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(860, 514);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.CustomerOrders);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDcheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "searchCustomer";
            this.Text = "searchCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDcheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button CustomerOrders;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Check;
    }
}