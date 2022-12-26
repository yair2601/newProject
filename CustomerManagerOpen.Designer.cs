namespace Project
{
    partial class CustomerManagerOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagerOpen));
            this.Add_Customer = new System.Windows.Forms.Button();
            this.update_Customer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Customer
            // 
            this.Add_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Add_Customer.Location = new System.Drawing.Point(718, 572);
            this.Add_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Customer.Name = "Add_Customer";
            this.Add_Customer.Size = new System.Drawing.Size(300, 109);
            this.Add_Customer.TabIndex = 0;
            this.Add_Customer.Text = "Add Customer";
            this.Add_Customer.UseVisualStyleBackColor = true;
            this.Add_Customer.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_Customer
            // 
            this.update_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.update_Customer.Location = new System.Drawing.Point(117, 572);
            this.update_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.update_Customer.Name = "update_Customer";
            this.update_Customer.Size = new System.Drawing.Size(319, 109);
            this.update_Customer.TabIndex = 1;
            this.update_Customer.Text = "Manage Existing Customer";
            this.update_Customer.UseVisualStyleBackColor = true;
            this.update_Customer.Click += new System.EventHandler(this.update_Customer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(465, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Customer Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(326, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(597, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "What would you like to do?";
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenu.Location = new System.Drawing.Point(412, 759);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(294, 76);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            // 
            // CustomerManagerOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1117, 894);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_Customer);
            this.Controls.Add(this.Add_Customer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerManagerOpen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Customer;
        private System.Windows.Forms.Button update_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MainMenu;
    }
}

