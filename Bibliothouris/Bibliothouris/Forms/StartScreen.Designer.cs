namespace Bibliothouris.Forms {
    partial class StartScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(54, 38);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(121, 44);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(237, 38);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(122, 44);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click_1);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 132);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnMembers);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnBooks;
    }
}