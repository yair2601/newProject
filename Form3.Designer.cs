namespace Project
{
    partial class Form3
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
            this.CreateEnployee = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateEnployee
            // 
            this.CreateEnployee.Location = new System.Drawing.Point(51, 260);
            this.CreateEnployee.Name = "CreateEnployee";
            this.CreateEnployee.Size = new System.Drawing.Size(201, 53);
            this.CreateEnployee.TabIndex = 0;
            this.CreateEnployee.Text = "Create new employee";
            this.CreateEnployee.UseVisualStyleBackColor = true;
            this.CreateEnployee.Click += new System.EventHandler(this.CreateEnployee_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.Location = new System.Drawing.Point(340, 260);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(144, 56);
            this.UpdateEmployee.TabIndex = 1;
            this.UpdateEmployee.Text = "Update Employee";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 368);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.CreateEnployee);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateEnployee;
        private System.Windows.Forms.Button UpdateEmployee;
    }
}