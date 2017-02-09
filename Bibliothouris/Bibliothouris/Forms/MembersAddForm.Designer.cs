namespace Bibliothouris.Forms
{
    partial class MembersAddForm
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.INSS = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(69, 6);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "firstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "lastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "street";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "postalCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "city";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "INSS";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(69, 22);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 8;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(69, 42);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 20);
            this.street.TabIndex = 9;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(69, 62);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 10;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(69, 84);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(100, 20);
            this.postalCode.TabIndex = 11;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(69, 110);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 12;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // INSS
            // 
            this.INSS.Location = new System.Drawing.Point(69, 136);
            this.INSS.Name = "INSS";
            this.INSS.Size = new System.Drawing.Size(100, 20);
            this.INSS.TabIndex = 13;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 187);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 14;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // MembersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.add);
            this.Controls.Add(this.INSS);
            this.Controls.Add(this.city);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.number);
            this.Controls.Add(this.street);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName);
            this.Name = "MembersAddForm";
            this.Text = "MembersAddForm";
            this.Load += new System.EventHandler(this.MembersAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox postalCode;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox INSS;
        private System.Windows.Forms.Button add;
    }
}